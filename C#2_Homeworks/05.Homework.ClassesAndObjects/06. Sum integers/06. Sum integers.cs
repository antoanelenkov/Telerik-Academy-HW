using System;

//•	You are given a sequence of positive integer values written into a string, separated by spaces.
//•	Write a function that reads these values from given string and calculates their sum.

class SumIntegers
{
    static void Main()
    {
        string sequence = "43 68 9 23 318";
        string[] stringArr=sequence.Split(' ');
        Console.WriteLine("The sum is: {0}", FindSumFromSequence(stringArr));
    }

    static int FindSumFromSequence(string[] arr)
    {
        int[] intArr = new int[arr.Length];
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            intArr[i] = Convert.ToInt32(arr[i]);
            sum += intArr[i];
        }
        return sum;
    }
}

