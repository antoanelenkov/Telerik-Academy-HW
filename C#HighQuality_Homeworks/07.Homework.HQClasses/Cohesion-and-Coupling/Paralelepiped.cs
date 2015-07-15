namespace CohesionAndCoupling
{
    public class Paralelepiped
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }

        public Paralelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double GetVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double GetDiagonalXYZ()
        {
            double distance = GeometryUtils.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public double GetDiagonalXY()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        public double GetDiagonalXZ()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public double GetDiagonalYZ()
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
