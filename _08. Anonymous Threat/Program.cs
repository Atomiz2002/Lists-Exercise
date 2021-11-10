/*using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat {
    class Program {
        static void Main(string[] args) {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            string input = Console.ReadLine();

            while (input != "3:1") {
                if (input == "merge") {
                    int start = input[1];
                    int end = input[2];
                    list.InsertRange(start, list.GetRange(start, end - start));
                    list.RemoveRange(start, end - start);
                } else {
                    int index = input[1];
                    int partitions = input[2];
                }

                input = Console.ReadLine();
            }
        }

        private static int Limiter(int index, List<int> list) {
            if (index < 0)
                return 0;
            else if (index >= list.Count)
                return list.Count - 1;
            else
                return index;
        }
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame {
    class Program {
        static void Main(string[] args) {
            List<string> list = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            int moves = 0;

            while (command != "end") {
                moves++;
                string[] tokens = command.Split();
                int index1 = int.Parse(tokens[0]);
                int index2 = int.Parse(tokens[1]);

                if (index1 < 0 || index2 < 0 || index1 >= list.Count || index2 >= list.Count || index1 == index2) {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    list.Insert(list.Count / 2, $"-{moves}a");
                    list.Insert(list.Count / 2, $"-{moves}a");
                } else if (list[index1] == list[index2]) {
                    Console.WriteLine($"Congrats! You have found matching elements - {list[index1]}!");

                    if (index1 > index2) {
                        list.RemoveAt(index1);
                        list.RemoveAt(index2);
                    } else {
                        list.RemoveAt(index2);
                        list.RemoveAt(index1);
                    }
                } else {
                    Console.WriteLine("Try again!");
                }
                command = Console.ReadLine();
            }

            if (command == "end" && list.Count == 0) {
                Console.WriteLine($"You have won in {moves} turns!");
            }

            if (command == "end" && list.Count != 0) {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}