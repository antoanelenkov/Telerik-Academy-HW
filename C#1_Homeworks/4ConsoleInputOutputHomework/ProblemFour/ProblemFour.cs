using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

namespace ProblemFour
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for the first number:");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for the second number:");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(numberOne > numberTwo ? "The first number \"{0}\" is greater" : "The second number \"{1}\" is greater", numberOne, numberTwo);
        }
    }
}
