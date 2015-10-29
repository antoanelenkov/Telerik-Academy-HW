using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _14.Labyrinth.BFS
{
    class Coordinates
    {
        public Coordinates(int x, int y,int value)
        {
            this.X = x;
            this.Y = y;
            this.Value = value;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var startPosition = new Coordinates(2, 1,0);

            string[,] labyrinth =
           {
                { "0", "0", "0", "X", "0", "X" },
                { "0", "X", "0", "X", "0", "X" },
                { "0", "*", "X", "0", "X", "0" },
                { "0", "X", "0", "0", "0", "0" },
                { "0", "0", "0", "X", "X", "0" },
                { "0", "0", "0", "X", "0", "X" }
            };

            TraverseLabyrinth(labyrinth, startPosition);

            labyrinth[startPosition.X, startPosition.Y] = "*";

            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if(labyrinth[i, j] == "0")
                    {
                        labyrinth[i, j] = "u";
                    }
                    Console.Write(labyrinth[i, j].PadLeft(3));
                }
                Console.WriteLine();
            }
        }

        public static void TraverseLabyrinth(string[,] matrix,Coordinates coordinates)
        {
            var path = new Queue<Coordinates>();
            Coordinates currentCoordinates = new Coordinates(coordinates.X, coordinates.Y,1);

            path.Enqueue(currentCoordinates);

            while (path.Count > 0)
            {
                currentCoordinates = path.Dequeue();
                     
                var currentValue= currentCoordinates.Value + 1;

                if (IsPossibleMove(matrix, currentCoordinates.X+1, currentCoordinates.Y))
                {
                    matrix[currentCoordinates.X+1, currentCoordinates.Y] = currentCoordinates.Value.ToString();              
                    path.Enqueue(new Coordinates(currentCoordinates.X + 1, currentCoordinates.Y, currentValue));
                }
                if (IsPossibleMove(matrix, currentCoordinates.X, currentCoordinates.Y + 1))
                {

                    matrix[currentCoordinates.X, currentCoordinates.Y+1] = currentCoordinates.Value.ToString();
                    path.Enqueue(new Coordinates(currentCoordinates.X , currentCoordinates.Y+1, currentValue));
                }
                if (IsPossibleMove(matrix, currentCoordinates.X, currentCoordinates.Y-1))
                {
                    matrix[currentCoordinates.X, currentCoordinates.Y-1] = currentCoordinates.Value.ToString();
                    path.Enqueue(new Coordinates(currentCoordinates.X, currentCoordinates.Y-1, currentValue));
                }
                if (IsPossibleMove(matrix, currentCoordinates.X-1, currentCoordinates.Y))
                {
                    matrix[currentCoordinates.X-1, currentCoordinates.Y] = currentCoordinates.Value.ToString();
                    path.Enqueue(new Coordinates(currentCoordinates.X -1, currentCoordinates.Y, currentValue));
                }

            }
        }

        public static bool IsPossibleMove(string[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }
            else if (matrix[row, col] == "X" || matrix[row, col] == "*"  || matrix[row, col] != "0")
            {
                return false;
            }

            return true;
        }
    }
}
