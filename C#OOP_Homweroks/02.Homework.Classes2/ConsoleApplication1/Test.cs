using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    class Test
    {
        static void Main(string[] args)
        {
            var pointOne = new Point3D(0, 2, 3);
            var pointTwo = new Point3D(3, 2, 3);

            //Console.WriteLine(pointOne);
            //Console.WriteLine(Calculations.FindDistance(pointOne,pointTwo));

            Path randomPath = new Path();
            randomPath.Sequence.Add(pointOne);
            randomPath.Sequence.Add(pointTwo);
            PathStorage.SavePath(randomPath,"randomPath");
            PathStorage.SavePath(randomPath, "randomPath");
            Console.WriteLine(String.Join("\nThe Points in the current path are:\n", PathStorage.Pathes));

            PathStorage.LoadPath("rasndomPath");
            Console.Write("The Points in the current path are:\n");
            Console.WriteLine(String.Join("\nThe Points in the current path are:\n", PathStorage.Pathes));

        }
    }
}
