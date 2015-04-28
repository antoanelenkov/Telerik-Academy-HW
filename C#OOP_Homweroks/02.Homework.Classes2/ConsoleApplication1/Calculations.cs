using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    static class Calculations
    {
        public static double FindDistance(Point3D firstPoint, Point3D secondPoint)
        {

            return Math.Sqrt(
                Math.Pow((firstPoint.X - secondPoint.X), 2) +
                Math.Pow((firstPoint.Y - secondPoint.Y), 2) +
                Math.Pow((firstPoint.Z - secondPoint.Z), 2));
        }
    }
}
