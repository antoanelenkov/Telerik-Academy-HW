using System;
using System.Collections.Generic;


/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	                    result
3, 2, 3, 4, 2, 2, 4	2, 3, 4*/


class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 3, 4, 5, 6, 7, 8, 11, 15, 3, 3, 4, 6, 7, 8, 9, 12, 14, 15, 18, 25, 67, 2, 2, 2, 1 };
        List<int> newArray = new List<int>();
        int sequenceLength = 0;
        int lengthCounter = 1;

        for (int i = 0; i <= array.Length; i++)
        {
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    lengthCounter++;
                }
                else
                {
                    break;
                }
            }
            if (lengthCounter > sequenceLength)
            {
                int jPosition = 0;
                newArray.Clear();
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        newArray.Add(array[j]);
                    }
                    else
                    {
                        jPosition = j;
                        break;
                    }
                }
                newArray.Add(array[jPosition]);
                sequenceLength = lengthCounter;
            }
            lengthCounter = 1;
        }

        Console.WriteLine(String.Join(", ", newArray));
        Console.WriteLine();

    }
}
