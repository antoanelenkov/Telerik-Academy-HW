using System;
/*
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix	
ha	fifi ho	hi
fo	ha	 hi	xx
xxx	ho	 ha	xx
result
ha, ha, ha		
 */

class Sequence
{
    static void Main(string[] args)
    {
        string[,] array ={{"ha","ha","ha","ha"},
                         {"fo","ha","hi","xx"},
                         {"xxx","ho","ha","xx"}};

        int sum = 1;
        int bestSum = 0;
        string bestElement = "";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4-1; j++)
            {
                //Checks from the current element the row after.
                for (int k = j; k < 3; k++)
                {
                    if (array[i, k] == array[i, k + 1])
                    {
                        sum++;
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestElement = array[i, k];
                        }
                    }
                }

                //Checks from the current element the column after.
                sum = 1;               
                for (int k = i; k < 2; k++)
                {
                    if (array[k, j] == array[k+1, j])
                    {
                        sum++;
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestElement = array[k, j];
                        }
                    }
                }

                //Checks from the current element the diagonal after.
                sum = 1;
                for (int k = i; k < 2; k++)
                {
                    if (array[k, k] == array[k + 1, k+1])
                    {
                        sum++;
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestElement = array[k, k];
                        }
                    }
                }
                sum = 1;
            }
        }
        Console.WriteLine("The string with name \"{0}\" is {1} times met in the matrix of strings.",bestElement,bestSum);

    }
}

