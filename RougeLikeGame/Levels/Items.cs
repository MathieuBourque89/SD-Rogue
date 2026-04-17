using RogueLib.Dungeon;
using RogueLib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox01.Levels;

internal class Items : Item
{
    public int amount { get; init; }
    public Items(Vector2 pos, int amt) : base('?', pos, ConsoleColor.Blue)
    {
        amount = amt;
    }
}
