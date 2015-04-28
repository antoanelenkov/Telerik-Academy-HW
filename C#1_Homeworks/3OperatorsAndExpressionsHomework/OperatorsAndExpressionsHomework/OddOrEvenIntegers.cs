using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given integer is odd or even.

namespace OperatorsAndExpressionsHomework
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int number = 5;
            if (number % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
        }
    }
}
