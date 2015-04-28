using System;
using System.Diagnostics;

/*Write a program that sorts an array of strings using the Quick sort algorithm.*/


class Program
{
    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[right];
        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }

            while (numbers[right] > pivot)
            {
                right--;
            }
            if (numbers[right] == pivot && numbers[left] == pivot)
            {
                left++;
            }
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        // For Recusrion
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort_Recursive(arr, left, pivot - 1);
            }

            if (pivot + 1 < right)
            {
                QuickSort_Recursive(arr, pivot + 1, right);
            }
        }
    }

    static void Main(string[] args)
    {
        //Stopwatch watch = Stopwatch.StartNew();  
        Console.WriteLine("The array before using the quicksort method:");
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 5, 3, 8, 7, 5, 2, 1, 9, 6, 5, 3, 8, 7, 5, 2, 1, 9, 6, 5, 3, 8, 7, 5, 2, 32, 23, 32, 3212, 213, 2131, 445, 456, 345, 435, 34543, 543, 32, 43, 57, 5, 64, 5 };
        Console.WriteLine(String.Join(", ", numbers));

        QuickSort_Recursive(numbers, 0, numbers.Length - 1);
        Console.WriteLine("The array after using the quicksort method:");
        Console.WriteLine(String.Join(", ", numbers));
        //watch.Stop();
        //Console.WriteLine(watch.ElapsedMilliseconds);
        Console.WriteLine();
    }
}

