using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IsThereRoadBetweenTwoPoints
{
    class Program
    {
        private static Stack<Coordinates> path = new Stack<Coordinates>();

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

            string[,] labyrinth =
           {
                { "0", "0", "0", "0", "0", "X", "0", "0" },
                { "X", "X", "0", "X", "0", "X", "X", "0" },
                { "0", "0", "0", "X", "0", "0", "0", "0" },
                { "0", "X", "0", "0", "0", "0", "X", "0" },
                { "0", "0", "X", "X", "X", "0", "0", "X" },
                { "0", "0", "0", "0", "X", "0", "0", "0" },
                { "0", "0", "0", "0", "0", "X", "0", "0" },
                { "X", "X", "0", "X", "0", "X", "X", "0" },
                { "0", "0", "0", "X", "0", "0", "0", "0" },
                { "0", "X", "0", "0", "0", "0", "X", "0" },
                { "0", "0", "X", "X", "X", "0", "0", "F" }
            };

            Console.WriteLine(IsThereAPath(labyrinth, startPosition.X, startPosition.Y) == true ? "Yes, there is a path" : "No, there is no path");
        }

        private static bool IsThereAPath(string[,] labyrinth, int row, int col)
        {
            if (!IsPassable(labyrinth, new Coordinates(row, col)))
            {
                return false;
            }

            if (labyrinth[row, col] == "F")
            {
                var pathToPrint = path.Reverse();
                PrintPath(pathToPrint);
                Console.WriteLine(pathToPrint.Count() + " steps needed!");
                return true;
            }

            var currentValue = labyrinth[row, col];

            path.Push(new Coordinates(row, col));
            labyrinth[row, col] = "P";

            if (IsThereAPath(labyrinth, row + 1, col))
            {
                return true;
            }
            if (IsThereAPath(labyrinth, row - 1, col))
            {
                return true;
            }
            if (IsThereAPath(labyrinth, row, col - 1))
            {
                return true;
            }
            if (IsThereAPath(labyrinth, row, col + 1))
            {
                return true;
            }

            path.Pop();
            labyrinth[row, col] = currentValue;

            return false;
        }

        private static bool IsPassable(string[,] labyrinth, Coordinates pos)
        {
            var rows = labyrinth.GetLength(0);
            var cols = labyrinth.GetLength(1);

            if (pos.X >= rows || pos.X < 0 || pos.Y >= cols || pos.Y < 0)
            {
                return false;
            }
            else if (labyrinth[pos.X, pos.Y] == "X" || labyrinth[pos.X, pos.Y] == "P")
            {
                return false;
            }

            return true;
        }

        private static void PrintLabyrinth<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void PrintPath<T>(IEnumerable<T> path)
        {
            Console.WriteLine(String.Join(", ", path));
        }
    }
}
