using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class Display
    {
        private double sizeInInches;
        private int colours;

        public Display(double sizeInInches, int colours)
        {
            this.SizeInInches = sizeInInches;
            this.Colours = colours;
        }
        public double SizeInInches
        {
            get { return this.sizeInInches; }
            set
            {
                if (value > 0)
                {
                    this.sizeInInches = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The size in inches must be non-negative value.");
                }
            }
        }
        public int Colours
        {
            get { return this.colours; }
            set
            {
                if (value > 0)
                {
                    this.colours = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The colours must be  non-negative value.");
                }
            }
        }
        public override string ToString()
        {
            return String.Format("Size: {0}, Number of colours: {1}", this.SizeInInches, this.Colours);
        }
    }
}
