using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads 3 real numbers from the console and prints their sum.

namespace ProblemOne
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for \"a\"");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for \"b\"");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for \"c\"");
            int c = int.Parse(Console.ReadLine());
            int d = a + b + c;
            Console.WriteLine("The sum of these 3 numbers is \"{0}\"", d);
        }
    }
}
