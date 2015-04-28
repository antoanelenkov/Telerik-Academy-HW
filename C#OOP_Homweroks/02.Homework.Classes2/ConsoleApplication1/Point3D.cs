using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    struct Point3D
    {
        private static readonly Point3D pointO;

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            pointO=new Point3D(0,0,0);
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            return string.Format("The coordinates of the point are [{0},{1},{2}].",this.X,this.Y,this.Z);
        }
    }
}
