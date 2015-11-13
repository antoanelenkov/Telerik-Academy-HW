using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//09. Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.

namespace _09.AdjacentCellsInMatrix
{
    class Program
    {
        private static Dictionary<string, int> occurances = new Dictionary<string, int>();
        private static int counter = 0;

        private struct Coordinates
        {
            public Coordinates(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int X { get; set; }

            public int Y { get; set; }

            public override string ToString()
            {
                return String.Format("[{0},{1}]", this.X, this.Y);
            }
        }

        static void Main()
        { 
            var startPosition = new Coordinates(0, 0);

            string[,] matrix =
           {
                { "1","3" ,"2", "2", "2" ,"4" },
                { "3","3" ,"3", "2", "4" ,"4" },
                { "4","3" ,"1", "2", "3" ,"3" },
                { "4","3" ,"1", "3", "3" ,"1" },
                { "4","3" ,"3", "3", "1" ,"1" },
            };

            var largestAreaCount = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != "V")
                    {
                        var currentAreaCount=FindMostAdjacentCells(matrix, i, j, matrix[i, j]);

                        if (largestAreaCount < currentAreaCount)
                        {
                            largestAreaCount = currentAreaCount;
                        }

                        counter = 0;
                    }
                }
            }

            Console.WriteLine(largestAreaCount);
        }

        private static int FindMostAdjacentCells(string[,] matrix, int row, int col, string last)
        {
            if (!IsPassable(matrix, new Coordinates(row, col), last))
            {
                return counter;
            }

            var currentValue = matrix[row, col];

            matrix[row, col] = "V";
            counter++;

            counter = FindMostAdjacentCells(matrix, row + 1, col, currentValue);
            counter = FindMostAdjacentCells(matrix, row - 1, col, currentValue);
            counter = FindMostAdjacentCells(matrix, row, col + 1, currentValue);
            counter = FindMostAdjacentCells(matrix, row, col - 1, currentValue);

            return counter;
        }

        private static bool IsPassable(string[,] matrix, Coordinates pos, string last)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);

            if (pos.X >= rows || pos.X < 0 || pos.Y >= cols || pos.Y < 0)
            {
                return false;
            }
            else if (matrix[pos.X, pos.Y] == "V" || matrix[pos.X, pos.Y] != last)
            {
                return false;
            }

            return true;
        }
    }
}
