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

        public Enemy(string name, Vector2 pos, char glyph, ConsoleColor color)
        {
            Name = name;
            Pos = pos;
            Glyph = glyph;
            _color = color;
        }

        public void Draw(IRenderWindow disp)
        {
            disp.Draw(Glyph, Pos, _color);
        }
    }
}
