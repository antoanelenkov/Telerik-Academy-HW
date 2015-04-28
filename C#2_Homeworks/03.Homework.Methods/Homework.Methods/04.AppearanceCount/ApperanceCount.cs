using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

class ApperanceCount
{

    static int CountHowManyTimesGivenNumberAppearsInArray(int[] givenArray,int givenNumber)
    {
        int counter=0;
        for (int i = 0; i < givenArray.Length; i++)
        {
            if (givenArray[i] == givenNumber)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 4, 5, 6, 7, 6, 5, 6, 7, 8, 4, 5, 6, 6, 3, 4, 354, 534, 543, 534, 534, 543, 5, 436, 4, 324, 234, 56, 36, 457, 56, 34, 543, 234, 32 };
        Console.WriteLine("the array is: {0}",String.Join(", ",array));
        Console.WriteLine("Enter a number to be checked in the array:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("This number is met {0} times in the given array",CountHowManyTimesGivenNumberAppearsInArray(array,number));
    }
}

