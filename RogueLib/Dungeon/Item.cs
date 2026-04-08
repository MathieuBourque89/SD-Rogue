using RogueLib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLib.Dungeon;

public abstract class Item : IDrawable
{
    public Vector2 Pos { get; set; }
    public char Glyph => _glyph;
    protected char _glyph;
    protected ConsoleColor _color;

    public Item(char glyph, Vector2 pos, ConsoleColor color = ScreenBuff._notAColor)
    {
        _color = color;
        _glyph = glyph;
        Pos = pos;
    }

    public void Draw(IRenderWindow disp)
    {
        disp.Draw(_glyph, Pos, _color);
    }
}
