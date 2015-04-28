using System;

/*Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm*/


class Program
{


    //This method is using recursion. 
    //There is easier way of solving the problem with "while" cycle. Check out how in internet.
    //The idea of this way of solving the problem is to practice "recursion" as a very serious and important part of programming. 
    //My advice is if you haven't met this before, take a look.

    static int BinarySearch(int[] methodArray, int key, int startPosition, int endPosition)
    {
        if (startPosition <= endPosition)
        {
            if (key == methodArray[(endPosition + startPosition) / 2])
            {
                return (endPosition + startPosition) / 2;
            }
            else
            {
                if (key < methodArray[(endPosition + startPosition) / 2])
                {
                    return BinarySearch(methodArray, key, startPosition, (endPosition + startPosition) / 2 - 1);
                }
                else
                {
                    return BinarySearch(methodArray, key, (endPosition + startPosition) / 2 + 1, endPosition);
                }
            }
        }
        else
        {
            return -1;
        }

    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        Console.WriteLine("Enter value for the number, you are searching for:");
        int key = int.Parse(Console.ReadLine());

        Console.WriteLine(BinarySearch(array, key, 0, array.Length - 1) == -1 ? "Element not found" : "This number is at position: {0}", BinarySearch(array, 4, 0, array.Length - 1));
    }
}

