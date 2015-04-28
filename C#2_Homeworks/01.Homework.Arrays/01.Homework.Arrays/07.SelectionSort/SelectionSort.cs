using System;

/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.*/


    class SelectionSort
    {
        static void Main()
        {
            int[] array = { 2, 7, 6, 8, 4, 5, 6, 7, 1, 0, 9, 1, 0 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int tempValue=array[i];
                        array[i] = array[j];
                        array[j] = tempValue;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",array));

        }
    }

