using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train {
    class Program {
        static void Main(string[] args) {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxPerWagon = Convert.ToInt32(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end") {
                if (input.StartsWith("Add")) {
                    wagons.Add(Convert.ToInt32(input.Split(' ')[1]));
                } else {
                    int passengers = Convert.ToInt32(input);

                    for (int i = 0; i < wagons.Count; i++)
                        if (wagons[i] + passengers <= maxPerWagon) {
                            wagons[i] += passengers;
                            break;
                        }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', wagons));
        }
    }
}