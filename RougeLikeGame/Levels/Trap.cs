using RogueLib.Dungeon;
using RogueLib.Utilities;

namespace SandBox01.Levels;

public class Trap : SpecialTiles
{
    public int damage { get; init; }
    public Trap(Vector2 pos, int damage) : base('^', pos, ConsoleColor.Red)
    {
        this.damage = damage;
    }
}