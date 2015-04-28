using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */

namespace FourDigitNumberProblemSix
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            int number = 1234;
            int d = number % 10;
            number /= 10;
            int c = number % 10;
            number /= 10;
            int b = number % 10;
            number /= 10;
            int a = number % 10;
            Console.WriteLine(a+b+c+d);
            Console.WriteLine(""+d+c+b+a);
            Console.WriteLine(""+a+c+b+d);

        }
    }
}
