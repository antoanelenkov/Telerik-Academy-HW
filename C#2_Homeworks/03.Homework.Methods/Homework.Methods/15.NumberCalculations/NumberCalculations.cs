using System;
using System.Numerics;
/*
 * Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).
 * */


class NumberCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("The minimum number from the set is: {0}", FindMinimumOfGivenSet(1, 2,"a", 3, 4, 5, 6, 7.5));
        Console.WriteLine("The maximum number from the set is: {0}", FindMaximumOfGivenSet(1, 2, 3, 4, 5,56.5, 6343242334323434));
        Console.WriteLine("The sum from the numbers in the set is: {0}", FindSumOfGivenSet(1, 2, 34324324, 43432432432432, 6332424233333432324, 6332424233333432324));
        Console.WriteLine("The product from the numbers int he set is: {0}", FindProductOfGivenSet(1, 2, 3, 45, 78.5, 4, 5, 6));
        Console.WriteLine("The average number from all of the numbers in the set is: {0:F2}", FindAverageOfGivenSet(1, 2, 3, 4, 25, 6));
    }

    static T  FindMinimumOfGivenSet<T>(params T[] numbers)
    {
        dynamic minNumber = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        return minNumber;
    }

    static T FindMaximumOfGivenSet<T>(params T[] numbers)
    {
        dynamic maxNumber = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        return maxNumber;
    }

    static T FindProductOfGivenSet<T>(params T[] numbers)
    {
        dynamic product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    static T FindSumOfGivenSet<T>(params T[] numbers)
    {
        dynamic sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    static T FindAverageOfGivenSet<T>(params T[] numbers)
    {
        dynamic sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
}


