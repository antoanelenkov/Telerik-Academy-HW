using System;

/*Write a program that fills and prints a matrix of size (n, n) as shown below:

1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
 */

class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for size of matrix:");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n,n];
        int counter = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i % 2 == 0)
                {
                    array[j, i] = counter;
                }
                else
                {
                    array[n-1 - j, i] = counter;
                }
                counter++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i,j].ToString().PadRight(3));
            }
            Console.WriteLine();
        }

    }
}

