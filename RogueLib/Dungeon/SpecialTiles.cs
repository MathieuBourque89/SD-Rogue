using RogueLib.Utilities;

namespace RogueLib.Dungeon;

public class SpecialTiles : IDrawable
{
    public Vector2 Pos { get; set; }
    public char Glyph => _glyph;
    protected char _glyph;
    protected ConsoleColor _color;

    public SpecialTiles(char glyph, Vector2 pos, ConsoleColor color = ScreenBuff._notAColor)
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