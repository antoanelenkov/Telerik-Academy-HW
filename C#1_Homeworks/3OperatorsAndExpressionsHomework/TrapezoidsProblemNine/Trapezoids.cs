using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace TrapezoidsProblemNine
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double a = 6;
            double b = 5;
            int h=9;
            double area = ((a + b) / 2 ) * h;
            Console.WriteLine(area);
        }
    }
}
