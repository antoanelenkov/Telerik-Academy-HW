using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
*/
namespace ComparingFloatsProblemThirteen
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double valueOne = 5.00000001;
            double valueTwo = 5.00000003;
            if ((Math.Abs(valueTwo) - Math.Abs(valueOne)) >= eps)//I use the "abs" function to make sure myself that when I subtract the two numbers, 
            {                                                    //the result will be with possitive value.
                Console.WriteLine("They are not equal");
            }
            else
            {
                Console.WriteLine("They are  equal");
            }
        }
    }
}
