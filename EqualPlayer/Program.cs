using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Player p1 = new Player(PlayerClass.Marksmen, "test");
            Player p2 = new Player(PlayerClass.Marksmen, "test");
            Console.WriteLine($"Hash code of player 1: {p1.GetNameHashCode()}");
            Console.WriteLine($"Hash code of player 1: {p1.GetClassHashCode()}");
            Console.WriteLine($"Hash code of player 1: {p1.GetHashCode()}");
            Console.WriteLine($"Hash code of player 2: {p2.GetNameHashCode()}");
            Console.WriteLine($"Hash code of player 2: {p2.GetClassHashCode()}");
            Console.WriteLine($"Hash code of player 2: {p2.GetHashCode()}");
            Console.WriteLine($"Are hash codes equal? {p1.GetHashCode() == p2.GetHashCode()}");
            Console.WriteLine($"Are players equal? {p1.Equals(p2)}");

            Player p3 = new Player(PlayerClass.Tank, "Ana");
            Player p4 = new Player(PlayerClass.Slayer, "Paulo");
            Player p5 = new Player(PlayerClass.Tank, "Ana");
            HashSet<Player> players = new HashSet<Player>() { p3, p4, p5 };

            foreach (Player p in players)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }

            PlayerStruct ps1 = new PlayerStruct(PlayerClass.Marksmen, "test");
            PlayerStruct ps2 = new PlayerStruct(PlayerClass.Marksmen, "test");
            Console.WriteLine($"Hash code of player struct 1: {ps1.GetHashCode()}");
            Console.WriteLine($"Hash code of player struct 2: {ps2.GetHashCode()}");
            Console.WriteLine($"Are player structs equal? {ps1.Equals(ps2)}");

        }
    }
}
