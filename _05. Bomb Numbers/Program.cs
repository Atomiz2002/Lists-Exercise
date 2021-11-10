using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers {
    class Program {
        static void Main(string[] args) {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = input[0];
            int power = input[1];

            // List<int> list = new List<int>(){9, 4, 4, 9, 6, 7, 8, 9, 1};
            // int bomb = 9;
            // int power = 2;

            int sum = 0;

            for (int i = 0; i < list.Count(); i++) {
                if (list[i] == bomb) {
                    i -= RemoveLeft(list, list.IndexOf(bomb), power) + 1;
                    RemoveRight(list, list.IndexOf(bomb), power);
                    list.Remove(bomb);
                }
            }

            foreach (int el in list)
                sum += el;

            Console.WriteLine(sum);
        }

        private static int RemoveLeft(List<int> list, int index, int amount) {
            int loops = 0;
            int start = Limiter(index - amount, list);

            for (int i = start; i < index; i++) {
                list.RemoveAt(start);
                loops++;
            }
            return loops;
        }

        private static int RemoveRight(List<int> list, int index, int amount) {
            int loops = 0;
            int start = Limiter(index + amount, list);

            for (int i = start; i > index; i--) {
                list.RemoveAt(index + 1);
                loops++;
            }
            return loops;
        }

        private static int Limiter(int index, List<int> list) {
            if (index < 0)
                return 0;
            else if (index >= list.Count)
                return list.Count() - 1;
            else
                return index;
        }
    }
}