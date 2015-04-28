using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Which of the following values can be assigned to a variable of type float and which to a variable 
//of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

namespace PrimitiveDataTypeAndVariables
{
    class FLoatOrDouble
    {
        static void Main(string[] args)
        {
            float numberOne = 12.345f;
            float numberTwo = 3456.091f;
            double numberThree = 34.567839023d;
            double numberFour = 8923.1234857d;

            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);
            Console.WriteLine(numberFour);
        }
    }
}
