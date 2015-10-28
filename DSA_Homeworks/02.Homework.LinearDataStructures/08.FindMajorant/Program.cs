using System;
using System.Collections.Generic;

namespace _08.FindMajorant
{
    /**The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    Write a program to find the majorant of given array (if exists).
    Example:
    {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3*/

    class Program
    {
        static void Main()
        {
            var numbers = new List<int>() { 1, 1, 1, 2, 3, 4, 4, 4, 4, 4, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7 };

            var resultNumber = numbers[0];
            var currentNumber = numbers[0];
            var mostOccurances = 0;
            var currentOccurances = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentNumber)
                {
                    currentOccurances += 1;
                }
                else
                {
                    if (currentOccurances > mostOccurances)
                    {
                        mostOccurances = currentOccurances;
                        resultNumber = currentNumber;

                        currentOccurances = 1;
                    }
                }

                currentNumber = numbers[i];
            }

            if (mostOccurances >= (numbers.Count / 2 + 1))
            {
                Console.WriteLine("there is majorant: {0} with {1} occurances in array of length {2}", resultNumber, mostOccurances, numbers.Count);
            }
            else
            {
                Console.WriteLine("there is no majorant");
            }
        }
    }
}
