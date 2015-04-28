using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix<T>
    {
        private int heigth;
        private int width;
        private T[,] arr;

        public Matrix(int heigth, int width)
        {
            this.width = width;
            this.heigth = heigth;
            arr = new T[this.heigth, this.width];
        }

        public int Heigth
        {
            get { return this.heigth; }
        }
        public int Width
        {
            get { return this.width; }
        }

        public T this[int heigth, int width]
        {
            get
            {
                if (width < 0 || width > this.width - 1 || heigth < 0 || heigth > this.heigth - 1)
                {
                    throw new IndexOutOfRangeException("There is no such index!");
                }
                else
                {
                    return this.arr[heigth, width];
                }
            }
            set
            {
                if (width < 0 || width > this.width - 1 || heigth < 0 || heigth > this.heigth - 1)
                {
                    throw new IndexOutOfRangeException("There is no such index!");
                }
                else
                {
                    this.arr[heigth, width] = value;
                }
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Heigth != second.Heigth || first.Width != second.Width)
            {
                throw new ArgumentException("The two matrix must be with the same size!");
            }
            else
            {
                int width = first.Width;
                int heigth = first.Heigth;
                var resultMatrix = new Matrix<T>(heigth, width);
                for (int i = 0; i < resultMatrix.Heigth; i++)
                {
                    for (int j = 0; j < resultMatrix.Width; j++)
                    {
                        resultMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
                    }
                }
                return resultMatrix;
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Heigth != second.Heigth || first.Width != second.Width)
            {
                throw new ArgumentException("The two matrix must be with the same size!");
            }
            else
            {
                int width = first.Width;
                int heigth = first.Heigth;
                var resultMatrix = new Matrix<T>(heigth, width);
                for (int i = 0; i < resultMatrix.Heigth; i++)
                {
                    for (int j = 0; j < resultMatrix.Width; j++)
                    {
                        resultMatrix[i, j] = (dynamic)first[i, j] - second[i, j];
                    }
                }
                return resultMatrix;
            }
        }


        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Heigth != second.Width || first.Width != second.Heigth)
            {
                throw new ArgumentException("The number of rows in the first matrix must be the same like the number of columnes in the second matrix!\n" +
                                            "The number of columnes in the first matrix must be the same like the number of rows in the second matrix!");
            }
            else
            {
                int width = first.Heigth;
                int heigth = second.Width;
                var resultMatrix = new Matrix<T>(heigth, width);
                for (int i = 0; i < resultMatrix.Heigth; i++)
                {
                    for (int j = 0; j < resultMatrix.Width; j++)
                    {
                        for (int k = 0; k < first.Width; k++)
                        {
                            resultMatrix[i, j] += (dynamic)first[i, k] * second[k, j];
                        }
                    }
                }
                return resultMatrix;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Heigth; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Heigth; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string[] result = new string[this.Heigth];
            for (int i = 0; i < this.Heigth; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < this.Width; j++)
                {
                    sb.Append(this.arr[i, j]+",");
                }
                sb.Remove(sb.Length - 1, 1);
                result[i] = sb.ToString();
            }
            return String.Join("\n",result);
      }

    }
}
