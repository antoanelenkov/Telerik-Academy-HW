using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a console application that calculates and prints the square root of the number 12345.
//Find in Internet “how to calculate square root in C#”.


namespace SquareRootProblemEight
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            double number = 12345;
            double squareRoot = Math.Sqrt(number);// I am using the class Math from the library.
            Console.WriteLine("{0:F3}", squareRoot);//F is for showing a number."3" is  for precision. It shows that you will see 3 numbers after the coma".
        }
    }
}
