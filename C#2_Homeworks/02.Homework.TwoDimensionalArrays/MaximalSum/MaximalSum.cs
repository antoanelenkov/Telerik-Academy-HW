using System;
/*Write a program that reads a rectangular matrix of size N x M 
 and finds in it the square 3 x 3 that has maximal sum of its elements.*/

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for heigth of the matrix:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for width of the matrix:");
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter value for element [{0},{1}]:",i,j);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int maxSum = int.MinValue;
            int sum = 0;
            int firstRow = 0;
            int firstColumn = 0;


            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < m-2; j++)
                {
                    sum = array[i, j] + array[i, j + 1] + array[i, j + 2] + array[i+1, j] + array[i+1, j + 1] + 
                        array[i+1, j + 2] + array[i+2, j] + array[i+2, j + 1] + array[i+2, j + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        firstRow = i;
                        firstColumn = j;
                    }
                }
            }

            Console.WriteLine("The area with the greatest sum is:");
            for (int i = firstRow; i < firstRow+3; i++)
            {
                for (int j = firstColumn; j < firstColumn+3; j++)
                {
                    Console.Write("{0} ",array[i,j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.WriteLine("The maximum sum is: {0}", maxSum);
        }
    }
}
