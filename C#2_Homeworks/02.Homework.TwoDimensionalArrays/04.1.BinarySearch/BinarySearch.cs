using System;
using System.Collections.Generic;



class BinarySearch
{
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

        Array.Sort(array);
        int index = Array.BinarySearch(array, k);
        if (index >= 0)
        {
            Console.WriteLine("The best number is the exact number: \"{0}\"", k, array[index]); 
        }
        else 
        {
            if (index == -1)
            {
                Console.WriteLine("There is no element smaller than \"{0}\"", k);
            }
            else
            {
                index = array.Length - 1;
                Console.WriteLine( "The best number before number \"{0}\" is: \"{1}\"", k, array[index]);
            }
        }
    }
}

