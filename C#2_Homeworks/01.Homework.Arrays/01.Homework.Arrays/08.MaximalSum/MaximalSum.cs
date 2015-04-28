using System;
using System.Collections.Generic;


/*Write a program that finds the sequence of maximal sum in given array.
Example:

input	                            result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
Can you do it with only one loop (with single scan through the elements of the array)?*/

class MaximalSum
{
    static void Main(string[] args)
    {
        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = int.MinValue;
        List<int> maxSumArray = new List<int>(2);
        List<int> finalMaxSumArray = new List<int>(2);
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            maxSumArray = new List<int>(2);
            for (int j = i; j < array.Length; j++)
            {

                maxSumArray.Add(array[j]);
                currentSum += array[j];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    finalMaxSumArray = new List<int>(2);
                    for (int k = 0; k < maxSumArray.Count; k++)
                    {
                        finalMaxSumArray.Add(maxSumArray[k]);
                    }
                }
            }
        }
        Console.WriteLine(String.Join(", ", finalMaxSumArray));
    }
}

