using System;
using System.Linq;
using System.Diagnostics;

internal class AssertionsHomework
{
    // In real situation consts will be in another util or validation class.
    private const string AssertNullMessage = " must not be null";
    private const string AssertStartIndexMessage = "Start index must be non-negative value";
    private const string AssertEndIndexMessage = "End index out of range";
    private const string AssertStartEndIndexMessage = "First index is greater than end index";

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array" + AssertNullMessage);

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);

            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i - 1]) >= 0, "The array was not sorted.");
        }
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array" + AssertNullMessage);
        Debug.Assert(value != null, "Value" + AssertNullMessage);

        for (int i = 1; i < arr.Length; i++)
        {
            Debug.Assert(arr[i].CompareTo(arr[i - 1]) >= 0, "The array was not sorted.");
        }

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array" + AssertNullMessage);
        Debug.Assert(startIndex >= 0, AssertStartIndexMessage);
        Debug.Assert(startIndex < arr.Length, AssertEndIndexMessage);
        Debug.Assert(startIndex <= endIndex, AssertStartEndIndexMessage);

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        for (int i = startIndex + 1; i < endIndex; i++)
        {
            Debug.Assert(arr[minElementIndex].CompareTo(arr[i]) <= 0, "The element is not the minimal in the array!");
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(x != null, "x" + AssertNullMessage);
        Debug.Assert(y != null, "y" + AssertNullMessage);

        T oldX = x;
        x = y;
        y = oldX;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array" + AssertNullMessage);
        Debug.Assert(arr != null, "Value" + AssertNullMessage);
        Debug.Assert(startIndex >= 0, AssertStartIndexMessage);
        Debug.Assert(startIndex < arr.Length, AssertEndIndexMessage);
        Debug.Assert(startIndex <= endIndex, AssertStartEndIndexMessage);

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }
}
