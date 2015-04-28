using System;
/*We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.
Example:

input array	S	result
2, 1, 2, 4, 3, 5, 2, 6	14	yes*/
 


//DOESN'T WORK. CHECK OUT THE LAST TWO PROBLEMS WITH "*"(20,21).



  
/*class Program
{
    static void Main(string[] args)
    {
        int[] array = { 4, 5, 2, 8, 6, 5, 7, 4, 5, 9, 8, 90, 6, 5 };
        Console.WriteLine("Enter value for the \"sum\":");
        int sum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the subset \"sum\":");
        int sum = int.Parse(Console.ReadLine());
        //First I need to sort the array. For this purpose, I will use "quicksort" method.
        QuickSort_Recursive(array, 0, array.Length - 1);
        Console.WriteLine(String.Join(", ", array));


        bool isTrue = false;
        SubsetOFSum(array, 0, sum, 0, 0, isTrue);
        Console.WriteLine(isTrue);

    }

    static void SubsetOFSum(int[] number, int innerSum, int sum, int startPosition,int EndPosition,bool isTrue)
    {
        if (innerSum < sum)
        {

            innerSum += number[i];
            i++;
            SubsetOFSum(number, innerSum, sum, i,j,isTrue);
            isTrue = true;
            Console.WriteLine(isTrue);
            return;
        }
        else
        {
            if (innerSum == sum)
            {
                Console.WriteLine("Inner sum:" + innerSum);
                Console.WriteLine("Sum:" + sum);
                isTrue = true;
                Console.WriteLine(isTrue);
                return;
            }
            else
            {
                innerSum = 0;
                j++;
                i = 0;
                SubsetOFSum(number, innerSum, sum, j,j,isTrue);
                isTrue = true;
                Console.WriteLine(isTrue);
                return;
            }
        }
    }














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
}*/

