using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle:Shape
    {
        public Triangle(double side, double height) : base(side, height) { }

        public override double CalculateSurface()
        {
            return this.Height * this.Width/2;
        }
    }
}
