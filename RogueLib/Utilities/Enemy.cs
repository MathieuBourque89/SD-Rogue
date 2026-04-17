using RogueLib.Dungeon;
using System;
using System.Collections.Generic;
using System.Text;
using TileSet = System.Collections.Generic.HashSet<RogueLib.Utilities.Vector2>;

namespace RogueLib.Utilities
{
    public class Enemy: IActor, IDrawable
    {
        public string Name { get; init; }
        public ConsoleColor _color;
        public Vector2 Pos { get; set; }
        public char Glyph;
        private Vector2 _dir;

        public Enemy(string name, Vector2 pos, char glyph, ConsoleColor color)
        {
            Name = name;
            Pos = pos;
            Glyph = glyph;
            _color = color;
            _dir = Vector2.N;
        }

        public void Draw(IRenderWindow disp)
        {
            disp.Draw(Glyph, Pos, _color);
        }

        public void Update(TileSet _walkables)
        {
            var movNorth = Pos + Vector2.N;
            var movWest = Pos + Vector2.W;
            var movSouth = Pos + Vector2.S;
            var movEast = Pos + Vector2.E;
            var newPos = Pos + _dir;

            if (_walkables.Contains(newPos))
            {
                Pos = newPos;
                return;
            }

            if (_walkables.Contains(movNorth))
            {
                _dir = Vector2.N;
                Pos = movNorth;
            } 
            else if (_walkables.Contains(movWest))
            {
                _dir = Vector2.W;
                Pos = movWest;
            }
            else if (_walkables.Contains(movSouth))
            {
                _dir = Vector2.S;
                Pos = movSouth;
            }
            else if (_walkables.Contains(movEast))
            {
               _dir = Vector2.E;
               Pos = movEast;
            }
        }
    }
}
