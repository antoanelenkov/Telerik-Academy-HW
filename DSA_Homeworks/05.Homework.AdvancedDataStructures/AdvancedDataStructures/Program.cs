using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace AdvancedDataStructures
{
    class Program
    {
        /*Implement a class PriorityQueue<T> based on the data structure "binary heap".
        Write a program to read a large collection of products(name + price) and efficiently find the first 20 products in the price range[a…b].
        Test for 500 000 products and 10 000 price searches.
        Hint: you may use OrderedBag<T> and sub-ranges.
        Write a program that finds a set of words (e.g. 1000 words) in a large text(e.g. 100 MB text file).
        Print how many times each word occurs in the text.
        Hint: you may find a C# trie in Internet.*/
        static void Main(string[] args)
        {
            var priorityQueue = new MyPriorityQueue<int>();

            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(18);
            priorityQueue.Enqueue(4);
            priorityQueue.Enqueue(105);
            priorityQueue.Enqueue(213);

            var last = priorityQueue.Dequeue();

            Console.WriteLine("Dequed: " + last);
            Console.WriteLine("Size of queue: " + priorityQueue.Count());
            Console.WriteLine("All elements: \n" + String.Join(", ", priorityQueue.All()));
        }
    }
}
