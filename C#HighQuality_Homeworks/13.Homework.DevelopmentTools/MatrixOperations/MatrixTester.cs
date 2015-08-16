namespace MatrixOperations
{
    using System;
    using System.Collections.Generic;

    class MatrixTester
    {
        static void Main()
        {
            Matrix<double> matrixOne = new Matrix<double>(2, 2);
            Matrix<double> matrixTwo = new Matrix<double>(2, 2);
            List<Matrix<double>> listOfMatrixes = new List<Matrix<double>>();
            listOfMatrixes.Add(matrixOne);
            listOfMatrixes.Add(matrixTwo);

            for (int k = 0; k < listOfMatrixes.Count; k++)
            {
                //Fill the matrix
                for (int i = 0; i < listOfMatrixes[k].Heigth; i++)
                {
                    for (int j = 0; j < listOfMatrixes[k].Width; j++)
                    {
                        Console.WriteLine("Fill element [{0},{1}]:", i, j);
                        listOfMatrixes[k][i, j] = double.Parse(Console.ReadLine());
                    }
                }
                //Print the matrix
                Console.WriteLine(listOfMatrixes[k].ToString());
            }

            //Matrix + Another matrix
            var addedResult = matrixOne + matrixTwo;
            Console.WriteLine("First matrix + second matrix:");
            Console.WriteLine(addedResult.ToString());

            //Matrix - Another matrix
            var subtractedResult = matrixOne - matrixTwo;
            Console.WriteLine("First matrix - second matrix:");
            Console.WriteLine(subtractedResult.ToString());

            //Matrix * Antoher matrix
            var multipliedResult = matrixOne * matrixTwo;
            Console.WriteLine("First matrix * second matrix:");
            Console.WriteLine(multipliedResult.ToString());

            //Check true and false
            if (matrixOne)
            {
                Console.WriteLine("The matrix  have only non-zero elements.");
            }
            else
            {
                Console.WriteLine("The matrix  have zero elements.");
            }
        }
    }
}
