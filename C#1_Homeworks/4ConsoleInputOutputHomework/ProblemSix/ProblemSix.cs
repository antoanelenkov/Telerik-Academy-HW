using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
//and solves it (prints its real roots).

namespace ProblemSix
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for \"a\":");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for \"b\":");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for \"c\":");
            int c = int.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant >= 0)
            {
                double rootOne = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double rootTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The first root is: {0}", rootOne);
                Console.WriteLine("The second root is: {0}", rootTwo);
            }
            else
            {
                Console.WriteLine("There are no real roots");
            }
        }
    }
}
