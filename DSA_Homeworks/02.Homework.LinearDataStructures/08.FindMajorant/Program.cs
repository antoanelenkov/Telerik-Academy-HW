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
            var numbers = new List<int>() { 1, 1, 1, 2, 3, 6, 6, 6, 6, 6, 6, 6, 4, 4, 4, 4, 4, 6, 6, 6, 6, 6, 6, 6, 7, 7 };

            // Figure it out how to do it with dynamic optimization

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
