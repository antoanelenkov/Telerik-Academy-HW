using System;
using System.Collections;
using System.Collections.Generic;

namespace _14.Labyrinth
{
    struct Coordinates
    {
        public Coordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }

    class Program
    {
        private static Queue<string> path = new Queue<string>();
        private static int pathCounter = 0;

        static void Main(string[] args)
        {

            var startPosition = new Coordinates(2, 1);

            string[,] labyrinth =
           {
                { "0", "0", "0", "X", "0", "X" },
                { "0", "X", "0", "X", "0", "X" },
                { "0", "0", "X", "0", "X", "0" },
                { "0", "X", "0", "0", "0", "0" },
                { "0", "0", "0", "X", "X", "0" },
                { "0", "0", "0", "X", "0", "X" }
            };

            TraverseLabyrinth(labyrinth, startPosition.X, startPosition.Y);

            labyrinth[startPosition.X, startPosition.Y] = "*";

            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    Console.Write(labyrinth[i,j].PadLeft(3));
                }
                Console.WriteLine();
            }
        }

        public static void TraverseLabyrinth(string[,] matrix,int row,int col)
        {
            if (IsPossibleMove(matrix, row, col + 1,row,col))
            {
                matrix[row, col + 1] = (++pathCounter).ToString();
                TraverseLabyrinth(matrix, row, col + 1);
                pathCounter--;
            }
            if (IsPossibleMove(matrix, row+1, col,row,col))
            {
                matrix[row + 1, col] = (++pathCounter).ToString();
                TraverseLabyrinth(matrix, row + 1, col);
                pathCounter--;
            }
            if (IsPossibleMove(matrix, row - 1, col,row,col))
            {
                matrix[row - 1, col] = (++pathCounter).ToString();
                TraverseLabyrinth(matrix, row - 1, col);
                pathCounter--;
            }
            if (IsPossibleMove(matrix, row , col-1,row,col))
            {
                matrix[row , col-1] = (++pathCounter).ToString();
                TraverseLabyrinth(matrix, row , col-1);
                pathCounter--;
            }
        }

        public static bool IsPossibleMove(string[,] matrix,int row,int col,int prevRow,int prevCol)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }
            else if (matrix[row, col] != "X" && (int.Parse(matrix[row, col])> int.Parse(matrix[prevRow, prevCol])))
            {
                return true;
            }
            else if (matrix[row, col] == "X" || matrix[row, col] != "0")
            {
                return false;
            }

            return true;
        }
    }
}
