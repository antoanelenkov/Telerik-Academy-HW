namespace Size
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Width must be positive number");
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Height must be positive number");
                }
            }
        }

        public static Size GetRotatedSize(Size currentSize, double angleInRadians)
        {
            double newWidth = GetRotatedDimension(angleInRadians, currentSize.Width);
            double newHeight = GetRotatedDimension(angleInRadians, currentSize.Height);

            Size result = new Size(newWidth, newHeight);

            return result;
        }

        private static double GetRotatedDimension(double angleInRadians, double dimension)
        {
            double cosinus = Math.Cos(angleInRadians);
            double sinus = Math.Sin(angleInRadians);
            double result = Math.Abs(sinus * dimension) + Math.Abs(cosinus * dimension);

            return result;
        }
    }
}
