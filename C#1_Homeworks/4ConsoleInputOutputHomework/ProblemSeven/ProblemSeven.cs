using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum.

namespace ProblemSeven
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for  five numbers, separate them with \"space\"\nand click \"enter\" in the end of input operation:");
            string[] array = Console.ReadLine().Split('/');         
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);
            int c = int.Parse(array[2]);
            int d = int.Parse(array[3]);
            int e = int.Parse(array[4]);
            Console.WriteLine("Their sum is:{0}",a+b+c+d+e);
          
            
            
        }
    }
}
