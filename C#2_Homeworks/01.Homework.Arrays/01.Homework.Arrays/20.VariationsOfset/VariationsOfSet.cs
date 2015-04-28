using System;
/*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
Example:

N	K	result
3	2	{1, 1} 
{1, 2} 
{1, 3} 
{2, 1} 
{2, 2} 
{2, 3} 
{3, 1} 
{3, 2} 
{3, 3}*/


class VariationsOfSet
{
    private static int numbersOnRow;
    private static int countOfNumbers;
    private static int[] array;

    //I am using recursive method. For more information about the exact method, open Nakov's book "Introduction to C#" and check out at page 365.
    static void GeneratePermutations(int currentNumber)
    {
        if (currentNumber == numbersOnRow)
        {
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


