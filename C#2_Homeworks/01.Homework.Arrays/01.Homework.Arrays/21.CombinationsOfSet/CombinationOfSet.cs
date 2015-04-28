using System;

/*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
Example:

N	K	result
5	2	{1, 2} 
{1, 3} 
{1, 4} 
{1, 5} 
{2, 3} 
{2, 4} 
{2, 5} 
{3, 4} 
{3, 5} 
{4, 5}*/


class CombinationsOfSet
{
    private static int numbersOnRow;
    private static int countOfNumbers;
    private static int[] array;

    //using the same recursive method as in the problem "PermutationsOfSet", but modified at one point. For more information about the exact method, open Nakov's book and check out at page 365.
    static void GeneratePermutations(int currentNumber)
    {
        if (currentNumber == numbersOnRow)
        {
            //here is the modification.If any next element is greater than previous, don't print anything.
            for (int i = 0; i < numbersOnRow - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return;
                }

            }
            Console.WriteLine(String.Join(", ", array));
            return;
        }
        else
        {
            for (int i = 1; i <= countOfNumbers; i++)
            {
                array[currentNumber] = i;
                GeneratePermutations(currentNumber + 1);
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for \"N\":");
        countOfNumbers = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for \"K\":");
        numbersOnRow = int.Parse(Console.ReadLine());
        array = new int[numbersOnRow];
        GeneratePermutations(0);
    }
}

