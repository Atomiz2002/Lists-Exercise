using System;
using System.Linq;

namespace _07._Append_Arrays {
    class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split('|').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            for (int i = input.Length - 1; i >= 0; i--)
                Console.Write($"{String.Join(' ', input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries))} ");
        }
    }
}