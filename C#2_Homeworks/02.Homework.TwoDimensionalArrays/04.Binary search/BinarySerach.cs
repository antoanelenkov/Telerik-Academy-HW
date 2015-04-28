using System;

/*
 * Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */


class BinarySerach
{
    //I make my own algorithm to solve the problem. Just to practice recursion.
    static int counter = 0;

    static int ModifiedBinarySearch(int[] array, int k, int leftBound, int RightBound)
    {

        int mid = (RightBound + leftBound) / 2;

        if (mid == leftBound && counter == 0)//counter is help variable for the algorithm to know if "left bound is "0"
        {
            if (k == array[mid])
            {
                return array[mid];
            }
            //if there is no result>>
            else
            {
                return int.MinValue;
            }
        }

        if (array[mid] == k)
        {
            return array[mid];
        }

        if (mid == RightBound)
        {
            return array[mid];
        }

        if (array[mid] < k && k < array[mid + 1] && mid < RightBound)
        {
            return array[mid];
        }
        else
        {
            if (k < array[mid])
            {
                return ModifiedBinarySearch(array, k, leftBound, mid - 1);
            }
            else
            {
                counter++;
                return ModifiedBinarySearch(array, k, mid + 1, RightBound);
            }
        }
    }

    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for length of the matrix:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for k:");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for element number \"{0}\":", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        //Sorts the array.
        SelectionSort(array);

        Console.WriteLine(String.Join(", ",array));

        //Binary search starts here.
        if (ModifiedBinarySearch(array, k, 0, n - 1) == int.MinValue)
        {
            Console.WriteLine("There is no element smaller than \"{0}\"", k);
        }
        else
        {
            Console.WriteLine(ModifiedBinarySearch(array, k, 0, n - 1) < k ? "The best number before number \"{0}\" is: \"{1}\"" : "The best number is the exact number: \"{0}\"", k, ModifiedBinarySearch(array, k, 0, n - 1));
        }
    }
}