//Write a program that reads N integers from the console 
//and reverses them using a stack. Use the Stack<int> class.

namespace NumbersInStack
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for n");
            int n = int.Parse(Console.ReadLine());
            var collection = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter current number to input in stack:");
                int curerent=int.Parse(Console.ReadLine());
                collection.Push(curerent);
            }

            Console.WriteLine("The numbers in reverse order are:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(collection.Pop());
            }
        }
    }
}
