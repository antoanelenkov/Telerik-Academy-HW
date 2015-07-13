namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class LoverOfThree
    {
        private static string[] typeOfDirectionCommands;
        private static int[] numberOfStepsCommands;

        private static int[] matrixSize;
        private static int[,] matrix;

        private static int currentRow;
        private static int currentCol;
        private static int previousRow;
        private static int previousCol;

        private static bool toChangeDirection;

        private static BigInteger result = 0;

        static void Main()
        {
            ReadInput();

            FillMatrix(matrixSize[0], matrixSize[1]);

            FindResult();

            Console.WriteLine(result);
        }

        private static void ReadInput()
        {
            matrixSize = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numberOfCommands = int.Parse(Console.ReadLine());

            string[] commands = new string[numberOfCommands];

            for (int i = 0; i < commands.Length; i++)
            {
                commands[i] = Console.ReadLine();
            }

            typeOfDirectionCommands = new string[commands.Length];
            numberOfStepsCommands = new int[commands.Length];

            for (int i = 0; i < commands.Length; i++)
            {
                typeOfDirectionCommands[i] = commands[i].Substring(0, 2);
                numberOfStepsCommands[i] = Convert.ToInt32(commands[i].Substring(2));
            }
        }

        private static void FillMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
            int numberOfRows = matrix.GetLength(0);
            int numberOfCols = matrix.GetLength(1);

            int rowCount = 0;
            int colCount = 0;
            for (int i = numberOfRows - 1; i >= 0; i--)
            {
                rowCount += colCount;

                for (int j = 0; j < numberOfCols; j++)
                {
                    matrix[i, j] = rowCount;
                    rowCount += 3;
                }

                rowCount = 0;
                colCount += 3;
            }
        }

        private static void ProcessCurrentMove()
        {
            var indexOfRows = matrix.GetLength(0) - 1;
            var indexOfColumns = matrix.GetLength(1) - 1;

            if ((currentRow < 0 || currentRow > indexOfRows) || (currentCol < 0 || currentCol > indexOfColumns))
            {
                currentRow = previousRow;
                currentCol = previousCol;

                toChangeDirection = true;
            }
            else
            {
                result += matrix[currentRow, currentCol];

                matrix[currentRow, currentCol] = 0; 

                toChangeDirection = false;
            }
        }

        private static void FindResult()
        {
            currentRow = matrix.GetLength(0) - 1;
            currentCol = 0;

            previousRow = currentRow;
            previousCol = currentCol;

            toChangeDirection = false;

            for (int i = 0; i < numberOfStepsCommands.Length; i++)
            {
                for (int j = 0; j < numberOfStepsCommands[i] - 1; j++)
                {
                    previousRow = currentRow;
                    previousCol = currentRow;

                    switch (typeOfDirectionCommands[i])
                    {
                        case "UR": 
                            currentRow--;
                            currentCol++;
                            ProcessCurrentMove();                        
                            break;
                        case "RU": 
                            currentRow--;
                            currentCol++;
                            ProcessCurrentMove(); 
                            break;

                        case "LU": 
                            currentRow--;
                            currentCol--;
                            ProcessCurrentMove(); 
                            break;
                        case "UL":
                            currentRow--;
                            currentCol--;
                            ProcessCurrentMove(); 
                            break;

                        case "RD": 
                            currentRow++;
                            currentCol++;
                            ProcessCurrentMove(); 
                            break;
                        case "DR":
                            currentRow++;
                            currentCol++;
                            ProcessCurrentMove(); 
                            break;

                        case "DL": 
                            currentRow++;
                            currentCol--;
                            ProcessCurrentMove(); 
                            break;
                        case "LD": 
                            currentRow++;
                            currentCol--;
                            ProcessCurrentMove(); 
                            break;
                        default:
                            break;
                    }

                    if (toChangeDirection == true)
                    {
                        break;
                    }
                }
            }
        }
    }
}
