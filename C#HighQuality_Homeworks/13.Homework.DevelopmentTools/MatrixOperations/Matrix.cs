namespace MatrixOperations
{
    using System;
    using System.Text;

    /// <summary>
    /// Perform matrix operations like adding and multiplying of matrices
    /// </summary>
    /// <typeparam name="T">This parameter must be any numeric type</typeparam>
    class Matrix<T>
    {
        private int heigth;
        private int width;
        private T[,] field;

        public Matrix(int heigth, int width)
        {
            this.width = width;
            this.heigth = heigth;
            field = new T[this.heigth, this.width];
        }

        public int Heigth
        {
            get { return this.heigth; }
        }
        public int Width
        {
            get { return this.width; }
        }

        /// <summary>
        /// Gives you the possibility to work with the Matrix object directly using its field
        /// </summary>
        /// <param name="row">Current row</param>
        /// <param name="col">Current column</param>
        /// <returns></returns>
        public T this[int row, int col]
        {
            get
            {
                if (col < 0 || col > this.width - 1 || row < 0 || row > this.heigth - 1)
                {
                    throw new IndexOutOfRangeException("There is no such index!");
                }
                else
                {
                    return this.field[row, col];
                }
            }
            set
            {
                if (col < 0 || col > this.width - 1 || row < 0 || row > this.heigth - 1)
                {
                    throw new IndexOutOfRangeException("There is no such index!");
                }
                else
                {
                    this.field[row, col] = value;
                }
            }
        }

        /// <summary>
        /// Defining operation "adding" of matrices
        /// </summary>
        /// <param name="first">first matrix to add</param>
        /// <param name="second">second matrix to add</param>
        /// <returns></returns>
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

        /// <summary>
        /// Defining operation "subtracting" of matrices
        /// </summary>
        /// <param name="first">first matrix to subtract</param>
        /// <param name="second">second matrix to subtract</param>
        /// <returns></returns>
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

        /// <summary>
        /// Defining operation "multiplying" of matrices
        /// </summary>
        /// <param name="first">first matrix to multiply</param>
        /// <param name="second">second matrix to multiply</param>
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

        /// <summary>
        /// Checks if a matrix has zero elements and if not, the matrix is evaluated in "true", otherwise "false"
        /// </summary>
        /// <param name="matrix">matrix to check</param>
        /// <returns>If the matrix is evaluated in "true" or "false"</returns>
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

        /// <summary>
        /// Checks if a matrix has only zero elements and if not, the matrix is evaluated in "true", otherwise "false"
        /// </summary>
        /// <param name="matrix">matrix to check</param>
        /// <returns>If the matrix is evaluated in "true" or "false"</returns>
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

        /// <summary>
        /// Transform the matrix in a good-looking string
        /// </summary>
        /// <returns>the transformed matrix</returns>
        public override string ToString()
        {
            string[] result = new string[this.Heigth];
            for (int i = 0; i < this.Heigth; i++)
            {
                var sb = new StringBuilder();
                for (int j = 0; j < this.Width; j++)
                {
                    sb.Append(this.field[i, j] + ",");
                }
                sb.Remove(sb.Length - 1, 1);
                result[i] = sb.ToString();
            }
            return String.Join("\n", result);
        }
    }
}
