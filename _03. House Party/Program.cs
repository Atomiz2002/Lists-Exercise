using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party {
    class Program {
        static void Main(string[] args) {
            int commands = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();

            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++) {
                string name = input.Split(' ')[0];
                bool going = input.Split(' ')[2] == "going!";

                if (going) {
                    if (guests.Contains(name))
                        Console.WriteLine($"{name} is already in the list!");
                    else
                        guests.Add(name);
                } else {
                    if (guests.Contains(name))
                        guests.Remove(name);
                    else
                        Console.WriteLine($"{name} is not in the list!");
                }
                input = Console.ReadLine();
            }

            foreach (string guest in guests)
                Console.WriteLine(guest);
        }
    }
}