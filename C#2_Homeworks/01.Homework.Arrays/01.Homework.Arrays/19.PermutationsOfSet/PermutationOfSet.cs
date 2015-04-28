using System;
/*Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
Example:

N	result
3	{1, 2, 3} 
{1, 3, 2} 
{2, 1, 3} 
{2, 3, 1} 
{3, 1, 2} 
{3, 2, 1}*/


class PermutationOfSet
{
    static void PrintPermutation(int firstelement,int range)
    {
        if (firstelement == range)
        {
            return;
        }

        for (int i=firstelement; i < range; i++)
        {
            Console.Write(firstelement);
            PrintPermutation(firstelement + 1, range);
            return;
        }
        Console.WriteLine();

    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5};
        PrintPermutation(0, 5);

    }
}

