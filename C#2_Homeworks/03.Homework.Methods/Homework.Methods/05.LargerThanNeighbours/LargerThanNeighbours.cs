using System;

//Write a method that checks if the element at given position in given array of integers is
//larger than its two neighbours (when such exist).

class LargerThanNeighbours
{
    static bool CheckIfElementIsLargerThanItsNeighbours(int[] array, int elementPosition)
    {
        bool isLarger = false;
        if (elementPosition > 0 && elementPosition < array.Length - 1)
        {
            if (array[elementPosition] > array[elementPosition - 1] && array[elementPosition] > array[elementPosition + 1])
            {
                isLarger = true;
            }
        }
        else
        {
            if (elementPosition == 0)
            {
                if (array[elementPosition] > array[elementPosition + 1])
                {
                    isLarger = true;
                }
            }
            if (elementPosition == array.Length-1)
            {
                if (array[elementPosition] > array[elementPosition - 1])
                {
                    isLarger = true;
                }
            }
        }
        return isLarger;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 4, 5, 6, 7, 6, 5, 6, 7, 8, 4, 5, 6, 6, 3, 4, 354, 534, 543, 534, 534, 543, 5, 436, 4, 324, 234, 56, 36, 457, 56, 34, 543, 234, 32 };
        Console.WriteLine("the array is: {0}",String.Join(", ",array));
        Console.WriteLine("Enter a position of element to be checked in the array:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine(CheckIfElementIsLargerThanItsNeighbours(array,position)?
            "This element is larger than it's neighbours":"This element is not larger than it's neighbours");   
    }
}

