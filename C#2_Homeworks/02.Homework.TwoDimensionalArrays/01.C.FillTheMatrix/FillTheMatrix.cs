using System;

/*Write a program that fills and prints a matrix of size (n, n) as shown below:

7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
 */


class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for size of matrix:");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];

        int row;
        int col;
        int counter = 1;
        for (int i = 1; i <= n; i++)//Inicialize the first triangle part of the matrix.
        {
            row = n - i;
            col = 0;
            for (int j = 0; j < i; j++)
            {
                array[row, col] = counter;
                row++;
                col++;
                counter++;
            }
        }

        for (int i = n - 1; i > 0; i--)//Inicialize the second triangle part of the matrix.
        {
            row = 0;
            col = n - (i);
            for (int j = 0; j < i; j++)
            {
                array[row, col] = counter;
                row++;
                col++;
                counter++;
            }
        }
        //Print.
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString().PadRight(3));
            }
            Console.WriteLine();
        }
    }
}

