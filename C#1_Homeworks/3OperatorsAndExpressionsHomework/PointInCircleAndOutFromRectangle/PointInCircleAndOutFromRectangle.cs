using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

namespace PointInCircleAndOutFromRectangle
{
    class PointInCircleAndOutFromRectangle
    {
        static void Main(string[] args)
        {
            float xCoordinate = 2.0f;
            float yCoordinate = 1.5f;
            if ((Math.Sqrt(Math.Pow((xCoordinate - 1), 2) + Math.Pow((yCoordinate - 1), 2)) < 1.5) && yCoordinate > 1)
            {
                Console.WriteLine("The point is in the circle and out of the rectangle");
            }
            else
            {
                Console.WriteLine("The point is NOT in the circle and out of the rectangle");
            }

        }
    }
}
