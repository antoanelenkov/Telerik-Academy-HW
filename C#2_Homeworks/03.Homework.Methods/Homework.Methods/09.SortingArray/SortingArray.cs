using System;
using System.Collections.Generic;

/*Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
 */


class SortingArray
{


    static int FindMaximalElement(int[] array, int index)
    {
        int maximalNumber = int.MinValue;
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > maximalNumber)
            {
                maximalNumber = array[i];
            }
        }
        return maximalNumber;
    }

    static List<int> SortArray(int[] array)
    {
        int maximalNumber = int.MinValue;
        int currentIndex = 0;
        List<int> sortedArray = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > maximalNumber)
                {
                    maximalNumber = array[j];
                    currentIndex = j;
                }
            }
            sortedArray.Add(maximalNumber);
            array[currentIndex] = int.MinValue;
            maximalNumber = int.MinValue;
        }
        return sortedArray;
    }

    static void Main(string[] args)
    {
        int[] givenArray = { 10, 2, 255, 5, 6, 7, 6, 56, 6, 7, 8 };
        Console.WriteLine("the array is: {0}", String.Join(", ", givenArray));
        Console.WriteLine();

        Console.Write("Enter starting index(Index can start from \"0\"):");
        int index = int.Parse(Console.ReadLine());  
        Console.WriteLine("The maximal element starting from index \"{0}\" is: {1}\n",index,FindMaximalElement(givenArray,index));

        Console.WriteLine("The sorted array in descending order is:");
        Console.WriteLine(String.Join(", ",SortArray(givenArray)));
        Console.WriteLine();
    }
    
}
