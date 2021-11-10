using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game {
    class Program {
        static void Main(string[] args) {
            List<int> deck1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (Math.Min(deck1.Count, deck2.Count) > 0) {
                if (deck1[0] > deck2[0]) {
                    deck1.Add(deck2[0]);
                    deck1.Add(deck1[0]);
                } else if (deck1[0] < deck2[0]) {
                    deck2.Add(deck1[0]);
                    deck2.Add(deck2[0]);
                }
                deck1.RemoveAt(0);
                deck2.RemoveAt(0);
            }

            for (int i = 0; i < Math.Max(deck1.Count, deck2.Count); i++)
                sum += deck1.Any() ? deck1[i] : deck2[i];

            Console.WriteLine($"{(deck1.Any() ? "First" : "Second")} player wins! Sum: {sum}");
        }
    }
}