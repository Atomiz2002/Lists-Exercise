using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations {
    class Program {
        static void Main(string[] args) {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "End") {
                string[] split = input.Split(' ');

                switch (split[0]) {
                    case "Add":
                        list.Add(Convert.ToInt32(split[1]));
                        break;

                    case "Insert":
                        if (Convert.ToInt32(split[2]) >= 0 && Convert.ToInt32(split[2]) < list.Count) {
                            list.Insert(Convert.ToInt32(split[2]), Convert.ToInt32(split[1]));
                        } else {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        if (Convert.ToInt32(split[1]) >= 0 && Convert.ToInt32(split[1]) < list.Count) {
                            list.RemoveAt(Convert.ToInt32(split[1]));
                        } else {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        if (split[1] == "left") {
                            for (int i = 0; i < Convert.ToInt32(split[2]); i++) {
                                list.Add(list[0]);
                                list.RemoveAt(0);
                            }
                        } else {
                            for (int i = 0; i < Convert.ToInt32(split[2]); i++) {
                                list.Insert(0, list.Last());
                                list.RemoveAt(list.Count - 1);
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(' ', list));
        }
    }
}