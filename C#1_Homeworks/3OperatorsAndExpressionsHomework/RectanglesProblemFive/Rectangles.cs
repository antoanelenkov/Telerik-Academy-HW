using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace RectanglesProblemFive
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            int width = 10;
            int heigth = 20;
            int perimeter=2*width+2*heigth;
            Console.WriteLine("The perimter is: {0}", perimeter);
        }
    }
}
