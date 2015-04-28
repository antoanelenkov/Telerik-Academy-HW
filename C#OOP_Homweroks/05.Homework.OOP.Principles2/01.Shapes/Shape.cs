using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        private double width = 0;
        private double height = 0;

        public double Width
        {
            get { return this.width; }
        }
        public double Height
        {
            get { return this.height; }
        }


        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract double CalculateSurface();
    }
}
