/*Write a program that reads a sequence of integers 
(List<int>) ending with an empty line and sorts 
them in an increasing order*/

namespace _03.SortedNumbers
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();
            string current;
            while (true)
            {
                Console.WriteLine("Enter current number to input in list and when you are ready, press [enter]:");
                current = Console.ReadLine();
                if (string.IsNullOrEmpty(current.ToString()))
                {
                    break;
                }
                collection.Add(int.Parse(current));
            }


            collection.Sort();
            Console.WriteLine(String.Join(",",collection));
        }
    }
}
