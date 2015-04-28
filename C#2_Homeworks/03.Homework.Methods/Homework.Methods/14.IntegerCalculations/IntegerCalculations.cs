using System;

/*
 * Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
 * */


class IntegerCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("The minimum number from the set is: {0}",FindMinimumOfGivenSet(1,2,3,4,5,6,7));
        Console.WriteLine("The maximum number from the set is: {0}", FindMaximumOfGivenSet(1, 2, 3, 4, 5, 6));
        Console.WriteLine("The sum from the numbers in the set is: {0}", FindSumOfGivenSet(1, 2, 3, 4, 25, 6));
        Console.WriteLine("The product from the numbers int he set is: {0}", FindProductOfGivenSet(1, 2, 3,45,78, 4, 5, 6));
        Console.WriteLine("The average number from all of the numbers in the set is: {0:F2}", FindAverageOfGivenSet(1, 2, 3, 4, 25, 6));
    }

    static int FindMinimumOfGivenSet(params int[] numbers)
    {
        int minNumber=int.MaxValue;
        for (int i= 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        return minNumber;
    }

    static int FindMaximumOfGivenSet(params int[] numbers)
    {
        int maxNumber = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        return maxNumber;
    }

    static int FindProductOfGivenSet(params int[] numbers)
    {
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
               product*= numbers[i];
        }
        return product;
    }

    static int FindSumOfGivenSet(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum+= numbers[i];
        }
        return sum;
    }

    static double FindAverageOfGivenSet(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return (double)sum / numbers.Length;
    }
}

