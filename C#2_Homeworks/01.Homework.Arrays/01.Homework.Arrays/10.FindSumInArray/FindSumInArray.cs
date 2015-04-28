using System;
using System.Collections.Generic;
/*Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5*/

namespace _10.FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            Console.WriteLine("Enter value for the sum, ");
            int s = int.Parse(Console.ReadLine());


            for (int i = 0; i <= 9; i++)
            {
                int sum = 0;
                List<int> sumArray = new List<int>(2);

                for (int j = i; j < array.Length; j++)
                {
                    sumArray.Add(array[j]);
                    sum += array[j];

                    if (sum == s)
                    {
                        Console.WriteLine(String.Join(", ", sumArray));
                        break;
                    }
                }

            }
        }
    }
}
