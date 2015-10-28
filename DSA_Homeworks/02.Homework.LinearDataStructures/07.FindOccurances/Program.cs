using System;

namespace _07.FindOccurances
{
    /*Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    2 → 2 times
    3 → 4 times
    4 → 3 times.*/

    class Program
    {
        static void Main()
        {
            var numbers = new int[5] { 100, 100, 999, 323, 400 };
            var occurances = new int[1000];

            foreach (var number in numbers)
            {
                occurances[number]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] != 0)
                {
                    Console.WriteLine("{0} -> {1} times",i,occurances[i]);
                }
            }
        }
    }
}
