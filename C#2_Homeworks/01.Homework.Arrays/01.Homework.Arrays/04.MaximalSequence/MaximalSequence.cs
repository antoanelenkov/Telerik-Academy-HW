using System;

/*Problem 4. Maximal sequence

Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	                          result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1      2 2 2*/



class MaximalSequence
{
    static void Main(string[] args)
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 3, 3, 3, 2, 2, 2, 1 };
        int bestSum = 0;
        int tempNumber = 0;
        int finalNumber = 0;
        int counter = 1;
        for (int i = 0; i <= array.Length; i++)
        {

            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] == array[j + 1])
                {
                    counter++;
                }
                else
                {
                    tempNumber = array[j];
                    break;
                }
            }
            if (counter > bestSum)
            {
                bestSum = counter;
                finalNumber = tempNumber;
            }
            counter = 1;
        }
        for (int i = 0; i < bestSum; i++)
        {
            Console.Write("{0} ", finalNumber);

        }
        Console.WriteLine();
    }
}

