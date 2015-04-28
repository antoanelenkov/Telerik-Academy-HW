using System;


class ProblemNineteen
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter positive integer number for width and heigth of the matrix:");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixMembers = new int[n, n];
        int row = 0;
        int col = 0 - 1;

        int stepsInSameDirection = n;//In the first line we have a sequence of "n" numbers.At the last column, they are "n-1" and so on...
        int counter = 0;//This variable I use to change the direction of the current sequqnce(Change the value of "currentDirection")
        int helpVariable = 2;//this variable I use to make sure, that the change of the direction will be on exactly every 2 loops(except the first one, after which I have to change the direction)
        int currentDirection = 1;
        //In the second for cicle I will use the thing that in every 2 loops, the direction of the rows or columns sequence of inserting values is changing.
        for (int i = 1; i <= Math.Pow((double)n, 2); i++)
        {
            switch (currentDirection)//This are the cases, which shows how to insert values in the array.
            {
                case 1: col++; break;
                case 2: row++; break;
                case 3: col--; break;
                case 4: row--; break;
            }
            stepsInSameDirection--;
            if (stepsInSameDirection == 0)
            {
                currentDirection++;
                stepsInSameDirection = n - counter - 1;
                helpVariable++;//this variable I use to make sure, that the change of the direction will be on exactly every 2 loops.
                if (helpVariable % 2 == 0)
                {
                    counter++;
                }
            }
            if (currentDirection == 5)
            {
                currentDirection = 1;
            }
            matrixMembers[row, col] = i;
        }

        for (int i = 0; i < n; i++)//For cycle to print the matrix.
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3}", matrixMembers[i, j]);
            }
            Console.WriteLine();
        }
    }

}

