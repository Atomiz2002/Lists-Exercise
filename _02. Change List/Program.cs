using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List {
    class Program {
        static void Main(string[] args) {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end") {
                int element = Convert.ToInt32(input.Split(' ')[1]);

                if (input.StartsWith("Delete")) {
                    list.RemoveAll(el => el == element);
                } else {
                    int position = Convert.ToInt32(input.Split(' ')[2]);
                    list.Insert(position, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', list));
        }
    }
}