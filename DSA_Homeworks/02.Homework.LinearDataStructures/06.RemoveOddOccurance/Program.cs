/*Write a program that removes from given sequence
all numbers that occur odd number of times.
Example:
{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}*/

namespace RemoveOddOccurance
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> collection = new LinkedList<int>(new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 });
            Dictionary<int, int> countedNumbers = new Dictionary<int, int>();

            foreach (var item in collection)
            {
                if (countedNumbers.ContainsKey(item))
                {
                    countedNumbers[item] = countedNumbers[item] + 1;
                }
                else
                {
                    countedNumbers.Add(item, 1);
                }
            }

            LinkedListNode<int> currentNode = collection.First;
            while (currentNode != null)
            {
                if (countedNumbers[currentNode.Value] % 2 != 0)
                {
                    int toRemove = currentNode.Value;
                    currentNode = currentNode.Next;
                    collection.Remove(toRemove);
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }

            Console.WriteLine(String.Join(",", collection));
        }
    }
}