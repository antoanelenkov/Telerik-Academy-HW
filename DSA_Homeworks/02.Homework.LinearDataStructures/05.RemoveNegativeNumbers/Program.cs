//Write a program that removes from given sequence 
//all negative numbers.

namespace _05.RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            //Usually the linkedList is used when we need to delete or insert values in the middle of the list, beacuse it is faster
            LinkedList<int> collection = new LinkedList<int>(new int[] { 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25 });
            var currentNode = collection.First;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            while (currentNode != null)
            {
                if (currentNode.Value < 0)
                {
                    var toRemove = currentNode;
                    currentNode = currentNode.Next;
                    collection.Remove(toRemove);
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(String.Join(",", collection));

            List<int> sequence = new List<int>(new int[] { 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 1, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25, 2, 3, -2, -5, -6, 4, 2, -25 });
            stopwatch.Start();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] < 0)
                {
                    sequence.Remove(sequence[i]);
                    i--;
                }
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.WriteLine(string.Join(",", sequence));
        }
    }
}
