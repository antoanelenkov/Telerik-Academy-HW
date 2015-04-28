using System;

//Write a method that returns the index of the first element in array 
//that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

class FirstLargerThanNeighbours
{

    static int FindTheFirstElementGreaterThanItsNeighbours(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] givenArray = { 1, 2, 4, 5, 6, 7, 6, 5, 6, 7, 8, 4, 5, 6, 6, 3, 4, 354, 534, 543, 534, 534, 543, 5, 436, 4, 324, 234, 56, 36, 457, 56, 34, 543, 234, 32 };
        Console.WriteLine("the array is: {0}", String.Join(", ", givenArray));
        Console.WriteLine(FindTheFirstElementGreaterThanItsNeighbours(givenArray) != -1 ? "The index of the first element(starting from \"0\") larger than it's neigbours is: {0}" : "There is no element bigger than it's neighbours", FindTheFirstElementGreaterThanItsNeighbours(givenArray));
    }
}

