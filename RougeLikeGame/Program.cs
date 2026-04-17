using RogueLib.Dungeon;
using RogueLib.Engine;
using RogueLib.Utilities;
using TileSet = System.Collections.Generic.HashSet<RogueLib.Utilities.Vector2>;

namespace RlGameNS;


class Program {

    const string menu = "______ _____ _____ _   _ _____ \r\n| ___ \\  _  |  __ \\ | | |  ___|\r\n| |_/ / | | | |  \\/ | | | |__  \r\n|    /| | | | | __| | | |  __| \r\n| |\\ \\\\ \\_/ / |_\\ \\ |_| | |___ \r\n\\_| \\_|\\___/ \\____/\\___/\\____/ ";

   static void Main(string[] args) {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(menu);
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nGreen Light Games");
      Console.ForegroundColor= ConsoleColor.Yellow;
      Console.WriteLine("\nRogueLib Engine Provided by Dave B.");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\nPress any key to start...");
      Console.ReadKey();
      Console.Clear();
      Game game = new MyGame();
      game.run();
      Console.Clear();
      Console.WriteLine("You found the exit! Congratulations!");
   }
}