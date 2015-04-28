using System;

/*Write a program that finds the most frequent number in an array.
Example:

input	result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	4 (5 times)*/



    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int bestSum = 0;
            int number = 0;
            int counter = 0;
            for (int i = 0; i <= 9; i++)
            {

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == i)
                    {
                        counter++;
                    }
                }
                if (counter > bestSum)
                {
                    bestSum = counter;
                    number = i;
                }
                counter = 0;
            }
                Console.WriteLine("{0}({1} times)", number,bestSum);
        }
   }

