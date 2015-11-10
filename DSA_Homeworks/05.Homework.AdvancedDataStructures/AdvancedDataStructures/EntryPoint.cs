using System;
using System.Diagnostics;
using Wintellect.PowerCollections;

namespace AdvancedDataStructures
{
    class EntryPoint
    {
        private const int wordsToAdd = 100000;
        private const int wordsToSearch = 1000;

        private static Random randomGenerator = new Random();


        static void Main()
        {
            /*Implement a class PriorityQueue<T> based on the data structure "binary heap".
            Write a program to read a large collection of products(name + price) and efficiently find the first 20 products in the price range[a…b].
            Test for 500 000 products and 10 000 price searches.
            Hint: you may use OrderedBag<T> and sub-ranges.
            Write a program that finds a set of words (e.g. 1000 words) in a large text(e.g. 100 MB text file).
            Print how many times each word occurs in the text.
            Hint: you may find a C# trie in Internet.*/
            var priorityQueue = new MyPriorityQueue<int>();

            priorityQueue.Enqueue(1);
            priorityQueue.Enqueue(3);
            priorityQueue.Enqueue(18);
            priorityQueue.Enqueue(4);
            priorityQueue.Enqueue(105);
            priorityQueue.Enqueue(213);

            var last = priorityQueue.Dequeue();

            Console.WriteLine("TASK 1:");
            Console.WriteLine("Dequed: " + last);
            Console.WriteLine("Size of queue: " + priorityQueue.Count());
            Console.WriteLine("All elements: \n" + String.Join(", ", priorityQueue.All()));
            Console.WriteLine();

            /*Write a program to read a large collection of products (name + price) and efficiently find
            the first 20 products in the price range [a…b].
            Test for 500 000 products and 10 000 price searches.
            Hint: you may use OrderedBag<T> and sub-ranges.*/
            var db = new ProductsDb();

            for (int i = 0; i < 500000; i++)
            {
                db.AddProduct(new Product(GetRandomName(), GetRandomPriceInRange(0, 100000)));
            }

            Console.WriteLine("TASK 2:");
            Console.WriteLine("500 000 products added");

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var productsInRange = db.GetProductsInPriceRange(100, 3000);
            stopWatch.Stop();

            Console.WriteLine("Alll products in this range: " + productsInRange.Count);
            Console.WriteLine("Elapsed time to find all products: "+ stopWatch.Elapsed);
            Console.WriteLine();

            /*Write a program that finds a set of words(e.g. 1000 words) in a large text(e.g. 100 MB text file).
            Print how many times each word occurs in the text.
            Hint: you may find a C# trie in Internet.*/
            var sw = new Stopwatch();

            var trie = new Trie();

            for (int i = 0; i < wordsToAdd; i++)
            {
                string word = GetRandomName();
                sw.Start();
                trie.Add(word);
                sw.Stop();
            }

            Console.WriteLine("TASK 3");
            Console.WriteLine("Added {0} words for {1} time", wordsToAdd, sw.Elapsed);

            sw.Reset();
            for (int i = 0; i < wordsToSearch; i++)
            {
                string word = GetRandomName();
                sw.Start();
                trie.GetWordOccurance(word);
                sw.Stop();
            }

            Console.WriteLine("Found {0} words for {1} time", wordsToSearch, sw.Elapsed);
            Console.WriteLine("Most common word: {0}", trie.GetMostCommonWord());

        }

        private static string GetRandomName()
        {
            var name = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                var charNumberInUTF = randomGenerator.Next(97, 122);
                name += (char)charNumberInUTF;
            }

            return name;
        }

        private static decimal GetRandomPriceInRange(int bottom, int top)
        {
            return randomGenerator.Next(bottom, top);
        }
    }
}
