using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

namespace PointInCircleProblemSeven
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = 2;
            double y = .0001;

            if (Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2))>2)
            {
                Console.WriteLine("The point is outside the circle");
            }
            else
            {
                Console.WriteLine("The point is in the circle");
            }
        }
    }
}
