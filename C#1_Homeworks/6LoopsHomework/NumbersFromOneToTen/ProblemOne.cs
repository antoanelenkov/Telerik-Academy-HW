using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters from the console a positive integer n and 
//prints all the numbers from 1 to n, on a single line, separated by a space.

namespace NumbersFromOneToTen
{
    class ProblemOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for\"n\"");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
