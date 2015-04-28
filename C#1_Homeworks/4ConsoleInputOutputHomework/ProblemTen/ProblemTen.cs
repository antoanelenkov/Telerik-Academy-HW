using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number n and prints on the 
//console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

namespace ProblemTen
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for a sequence length:");
            int n = int.Parse(Console.ReadLine());
            int firstMember = 0;
            int secondMember = 1;
            int nextMember = 0;

            if (n == 0)
            {

            }
            if (n == 1)
            {
                Console.WriteLine("0");
            }
            if (n == 2)
            {
                Console.WriteLine("0");
                Console.WriteLine("1");
            }
            if (n > 2)
            {
                Console.WriteLine("0");
                Console.WriteLine("1");

                for (int i = 2; i < n; i++)
                {
                    nextMember = firstMember + secondMember;
                    Console.WriteLine(nextMember);
                    firstMember = secondMember;
                    secondMember = nextMember;

                }
            }

        }
    }
}
