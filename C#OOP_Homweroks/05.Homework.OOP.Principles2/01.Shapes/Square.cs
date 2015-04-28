using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square:Shape
    {
        public Square(double side) : base(side, side) { }

        override public double CalculateSurface()
        {
            return this.Height*this.Width;
        }


    }
}
