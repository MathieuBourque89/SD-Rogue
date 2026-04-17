using RogueLib.Dungeon;
using RogueLib.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox01.Levels;

internal class Exit : Item
{
    public int amount { get; init; }
    public Exit(Vector2 pos, int amt) : base('⬛', pos, ConsoleColor.DarkBlue)
    {
        amount = amt;
    }
}
