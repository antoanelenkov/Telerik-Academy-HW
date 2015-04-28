using System;

/*Write a program that fills and prints a matrix of size (n, n) as shown below:

1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
 */

namespace _01.D.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for size of matrix:");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int numberOfcycles = n * n / 2 - 1;
            int row = 0;
            int col = 0;

            int oneDirectionCounter = n - 1;//it changes in every two cycles, except of the first 3 cycles.
            int value = 1;
            for (int i = 1; i < numberOfcycles + 1; i++)
            {
                int Direction = (4 + i) % 4;//This var changes the direction of the filled values in the matrix.

                if (value == 1)
                {
                    for (int j = 0; j < oneDirectionCounter; j++)
                    {
                        array[row, col] = value;
                        value++;

                        switch (Direction)
                        {
                            case 1: row++; break;
                            case 2: col++; break;
                            case 3: row--; break;
                            case 0: col--; break;
                        }

                    }
                    continue;
                }

                if (i % 2 == 0)
                {
                    for (int j = 0; j < oneDirectionCounter; j++)
                    {
                        array[row, col] = value;
                        value++;

                        switch (Direction)
                        {
                            case 1: row++; break;
                            case 2: col++; break;
                            case 3: row--; break;
                            case 0: col--; break;
                        }
                        if (value == n * n)//fill the last symbol.
                        {
                            array[row, col] = value;
                        }
                    }
                }

                if (i% 2 != 0)
                {
                    for (int j = 0; j < oneDirectionCounter; j++)
                    {
                        array[row, col] = value;
                        value++;

                        switch (Direction)
                        {
                            case 1: row++; break;
                            case 2: col++; break;
                            case 3: row--; break;
                            case 0: col--; break;
                        }
                        if (value == n * n)//fill the last symbol.
                        {
                            array[row, col] = value;
                        }
                    }

                    oneDirectionCounter--;
                }
            }

            //print
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
}
