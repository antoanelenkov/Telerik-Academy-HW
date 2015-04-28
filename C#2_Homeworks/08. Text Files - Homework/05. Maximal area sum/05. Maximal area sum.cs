using System;
using System.IO;
using System.Text;

/*•	Write a program that reads a text file containing a square matrix of numbers.
  •	Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
    o	The first line in the input file contains the size of matrix N.
    o	Each of the next N lines contain N numbers separated by space.
    o	The output should be a single number in a separate text file.*/

class MaximalAreaSum
{
    static void Main()
    {
        using (var reader = new StreamReader("Matrix.txt"))
        {
            string line = reader.ReadLine();
            int size = int.Parse(line);
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                line = reader.ReadLine();
                string[] numbers = line.Split(' ');
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = int.Parse(numbers[j]);
                }
            }
            int maxSum = 0;
            for (int i = 0; i < size-1; i++)
            {
                for (int j = 0; j < size-1; j++)
                {
                    if ((arr[i, j] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1]) > maxSum)
                    {
                        maxSum = (arr[i, j] + arr[i, j + 1] + arr[i + 1, j] + arr[i + 1, j + 1]);
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("MatrixResult.txt"))
            {
                writer.WriteLine(maxSum);
            }
            using (StreamReader readResult = new StreamReader("MatrixResult.txt"))
            {
                Console.WriteLine("The output in the result text file is:");
                Console.WriteLine(readResult.ReadLine());
            }
        }

    }
}

