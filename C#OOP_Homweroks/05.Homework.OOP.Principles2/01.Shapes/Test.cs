using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Test
    {
        static void Main()
        {
            var shapesCollection = new Shape[]{
                new Triangle(10.5,12),
                new Triangle(5.5,6),
                new Square(10.5),
                new Square(9),
                new Rectangular(10.5,12),
                new Rectangular(10.5,12)
            };

            foreach (var shape in shapesCollection)
            {
                Console.WriteLine("size of shape is: {0}",shape.CalculateSurface());
            }
        }
    }
}
