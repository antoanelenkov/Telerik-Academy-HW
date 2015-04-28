using System;

/*
 * Write a class Matrix, to hold a matrix of integers. 
 * Overload the operators for adding, subtracting and multiplying of matrices, 
 * indexer for accessing the matrix content and ToString().
*/


class Matrix
{
    private int[,] firstMatrix;
    private int[,] secondMatrix;

    public Matrix(int[,] firstMatrix, int[,] secondMatrix)
    {
        this.firstMatrix = firstMatrix;
        this.secondMatrix = secondMatrix;
    }

    //This method add two matrixes.Check out how in google.
    public int[,] AddMatrixes()
    {
        int[,] finalMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < finalMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < finalMatrix.GetLength(1); j++)
            {
                finalMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
            }
        }
        return finalMatrix;
    }

    //This method subtract two matrixes.Check out how in google.
    public int[,] SubtractMatrixes()
    {
        int[,] finalMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < finalMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < finalMatrix.GetLength(1); j++)
            {
                finalMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
            }
        }
        return finalMatrix;
    }

    //This method subtract two matrixes.Check out how in google.
    public int[,] MultiplyMatrixes()
    {
        int[,] finalMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < finalMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < finalMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < finalMatrix.GetLength(0); k++)
                {
                    finalMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }

            }
        }
        return finalMatrix;
    }

    //Utility method.There is no need for the class to be instanced.
    public static void FillMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Enter value for element \"{0}\":", (i * matrix.GetLength(0) + j + 1));
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    //Utility method.There is no need for the class to be instanced.
    public static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine("The result matrix after the operation is:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j].ToString().PadRight(3));
            }
            Console.WriteLine();
        }
    }

    //Utility method.There is no need for the class to be instanced.
    public static void PrintElement(int[,] matrix, int row, int column)
    {
        Console.Write("The element of the matrix at position \"{0},{1}\": ", row, column);
        Console.WriteLine(matrix[row, column]);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Note: Both of the matrixes must have the same heigth and width!");
        Console.WriteLine("Enter value for heigth of the matrixes:");
        int heigth = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for width of the matrixes:");
        int width = int.Parse(Console.ReadLine());
        int[,] firstMatrix = new int[heigth, width];
        int[,] secondMatrix = new int[heigth, width];

        //Fills the matrixes.
        Console.WriteLine("Fill the first matrix:");
        FillMatrix(firstMatrix);
        Console.WriteLine("Fill the second matrix:");
        FillMatrix(secondMatrix);

        Matrix resultMatrix = new Matrix(firstMatrix, secondMatrix);
        int[,] addedMatrixes = resultMatrix.AddMatrixes();
        int[,] subtractedMatrixes = resultMatrix.SubtractMatrixes();
        int[,] multipliedMatrixes = resultMatrix.MultiplyMatrixes();

        //User operation options.
        Console.WriteLine("Choose operation:");
        Console.WriteLine("For adding, press \"1\".");
        Console.WriteLine("For subtracting, press \"2\".");
        Console.WriteLine("For multiplying, press \"3\".");
        Console.WriteLine("For printing exact element, press \"4\".");
        Console.WriteLine("If you are ready with operations, pres \"escape\".");
        ConsoleKeyInfo button;
        do
        {
            button = Console.ReadKey();
            if (button.Key == ConsoleKey.D1 || button.Key == ConsoleKey.D2 || button.Key == ConsoleKey.D3 || button.Key == ConsoleKey.D4)
            {
                if (button.Key == ConsoleKey.D1)
                {
                    Console.WriteLine();
                    PrintMatrix(addedMatrixes);
                }
                if (button.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    PrintMatrix(subtractedMatrixes);
                }
                if (button.Key == ConsoleKey.D3)
                {
                    Console.WriteLine();
                    PrintMatrix(multipliedMatrixes);
                }
                if (button.Key == ConsoleKey.D4)
                {
                    Console.WriteLine();
                    Console.WriteLine("If you want to print elment, choose the matrix, from which you want the element.");
                    Console.WriteLine("For the matrix as a result from the added matrixes, press \"1\"");
                    Console.WriteLine("For the matrix as a result from the subtracted matrixes, press \"2\"");
                    Console.WriteLine("For the matrix as a result from the multyplied matrixes, press \"3\"");
                    button = Console.ReadKey();
                    if (button.Key == ConsoleKey.D1 || button.Key == ConsoleKey.D2 || button.Key == ConsoleKey.D3)
                    {
                        if (button.Key == ConsoleKey.D1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter value for index from \"1\" to \"{0}\" for row and press \"enter\":",heigth);
                            int row = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for index from \"1\" to \"{0}\" for column and press \"enter\":", width);
                            int column = int.Parse(Console.ReadLine());
                            PrintElement(addedMatrixes, row-1, column-1);
                        }
                        if (button.Key == ConsoleKey.D2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter value for index from \"1\" to \"{0}\" for row and press \"enter\":", heigth);
                            int row = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for index from \"1\" to \"{0}\" for column and press \"enter\":", width);
                            int column = int.Parse(Console.ReadLine());
                            PrintElement(subtractedMatrixes, row-1, column-1);
                        }
                        if (button.Key == ConsoleKey.D3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter value for index from \"1\" to \"{0}\" for row and press \"enter\":", heigth);
                            int row = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter value for index from \"1\" to \"{0}\" for column and press \"enter\":", width);
                            int column = int.Parse(Console.ReadLine());
                            PrintElement(multipliedMatrixes, row-1, column-1);
                        }
                    }
                    else
                    {
                        if (button.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter correct command!");
                        }
                    }            
                }
            }
            else
            {
                if (button.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter correct command!");
                }
            }
        }
        while (button.Key != ConsoleKey.Escape);
    }
}

