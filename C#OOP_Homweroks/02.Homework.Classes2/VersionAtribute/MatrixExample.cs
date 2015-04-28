using System;
using System.Text;


namespace VersionAttribute
{
    [Version("1.1")]

    class Matrix
    {
        private int heigth;
        private int width;
        int[,] arr;


        public Matrix(int heigth, int width)
        {
            this.width = width;
            this.heigth = heigth;
            arr = new int[this.heigth, this.width];
        }

        //[Version("1.4")] - not allowed

        public int Heigth
        {
            get { return this.heigth; }
        }
        public int Width
        {
            get { return this.width; }
        }

        [Version("1.4")]

        public static Matrix DoSomething(Matrix first, Matrix second)
        {
            return first;
        }



    }

}