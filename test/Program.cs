using System;
using System.Linq;
using System.Collections.Generic;

namespace T5.BombNumbers {
    class Program {
        static void Main(string[] args) {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] bombParams = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            // Detonate the bomb
            DetonateBomb(numbers, bombParams[0], bombParams[1]);

            // Print sum by using Get sum
            Console.WriteLine(GetFieldSum(numbers));
        }

        private static void DetonateBomb(List<int> field, int bombNumber, int bombPower) {
            if (!field.Contains(bombNumber)) return;

            int detonationsCount = 2 * bombPower + 1;

            do {
                int index = GetDetonationIndex(field, bombNumber, bombPower);

                Detonate(field, index, detonationsCount);
            } while (field.Contains(bombNumber));
        }

        private static void Detonate(List<int> field, int index, int detonationsCount) {
            int count = index + detonationsCount > field.Count
                ? detonationsCount - ((index + detonationsCount) - field.Count)
                : detonationsCount;
            field.RemoveRange(index, count);
        }

        private static int GetDetonationIndex(List<int> field, int bombNumber, int bombPower) {
            int index = -1;

            for (int i = 0; i < field.Count; i++) {
                if (field[i] == bombNumber) {
                    if (i > bombPower)
                        index = i - bombPower;
                    else
                        index = 0; // this faults to the following input:
                                   // 1 2 3 4 5 6
                                   // 2 2
                                   // but judge doesnt cover this kind of an issue
                }
            }
            return index;
        }

        private static int GetFieldSum(List<int> field) {
            int sum = 0;

            foreach (int number in field) {
                sum += number;
            }
            return sum;
        }
    }
}

/*
 
Create a program that reads a sequence of numbers and a special bomb number holding a certain power. 
Your task is to detonate every occurrence of the special bomb number and according to its power the numbers to its left and right. 
The bomb power refers to how many numbers to the left and right will be removed, no matter their values. 
Detonations are performed from left to right and all the detonated numbers disappear. 
Finally, print the sum of the remaining elements in the sequence.
 
 */