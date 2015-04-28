using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassesHomework
{
    static class PathStorage
    {
        private static List<Path> pathes = new List<Path>();

        public static List<Path> Pathes
        {
            get { return pathes; }
            set { pathes = value; }
        }
        //In my text files there are more than just one path, because I decided that different paths could be added in txt files with the same names.
        public static void LoadPath(string pathName)
        {           
            try
            {
                var reader = new StreamReader(String.Format("{0}.txt", pathName));
                using (reader)
                {
                    string buffer = reader.ReadLine();
                    do
                    {
                        double[] coordinates = buffer
                            .Split(',')
                            .Select(double.Parse)
                            .ToArray();
                        Path currentPath = new Path();
                        for (int i = 0; i < coordinates.Length; i += 3)
                        {
                            Point3D currentPoint = new Point3D(coordinates[i], coordinates[i + 1], coordinates[i + 2]);
                            currentPath.Sequence.Add(currentPoint);
                        }
                        pathes.Add(currentPath);
                        buffer = reader.ReadLine();
                    }
                    while (buffer != null);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file could not be found!");
            }

        }

        public static void SavePath(Path path,string pathName)
        {
            StringBuilder coordinates = new StringBuilder();
            foreach (var point in path.Sequence)
            {
                foreach (var letter in point.ToString())
                {
                    if (char.IsDigit(letter))
                    {
                        coordinates.Append(letter+",");
                    }
                }

            }
            coordinates.Remove(coordinates.Length - 1, 1);//delete the last ","
            var writer = new StreamWriter(String.Format("{0}.txt",pathName),true);
            using (writer)
            {
                writer.WriteLine(coordinates);
            }
        }



    }
}
