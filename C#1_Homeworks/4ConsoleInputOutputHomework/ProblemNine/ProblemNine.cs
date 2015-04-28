using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters a number n and after that 
//enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

namespace ProblemNine
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter valuse for\"n\":");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter value for the \"{0}\" number:",i);
                int var = int.Parse(Console.ReadLine());
                sum += var;
            }
            Console.WriteLine("The sum is:{0}",sum);

        }
    }
}
