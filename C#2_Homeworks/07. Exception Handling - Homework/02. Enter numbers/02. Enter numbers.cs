using System;

/*•	Write a method ReadNumber(int start, int end) that enters an integer number in a given 
 * range [start…end].
    o	If an invalid number or non-number text is entered, the method should throw an exception.
  •	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 
 * 1 < a1 < … < a10 < 100*/

class EnterNumbers
{
    private static int countOfNumbers = 5;

    static void Main()
    {
        int min = 0;
        int max = 50;
        //NOTE!!! To check the solution of the second part of the problem, do that: "//ReadNumber(min, max);"
        ReadNumber(min, max);
        ReadIncreasingNumbers(min, max);

    }

    static void ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter {0} numbers in the of range {1}-{2}:",countOfNumbers, start,end);
        try
        {
            for (int i = 0; i < end - start; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > end || number < start)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        catch (FormatException a)
        {
            throw new FormatException("Wrong format!!!");
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new FormatException("Number out of bounds!!!");
        }
    }

    static void ReadIncreasingNumbers(int start, int end)
    {
        Console.WriteLine("Enter {0} numbers in the range of {1}-{2}:", countOfNumbers, start, end);
        try
        {
            int previousNumber = start-1;
            for (int i = 0; i < end - start; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > end || number < start || number <= previousNumber)
                {
                    throw new ArgumentOutOfRangeException();
                }
                previousNumber = number;
            }
        }
        catch (FormatException a)
        {
            throw new FormatException("Wrong format!!!");
        }
        catch (ArgumentOutOfRangeException)
        {
            throw new FormatException("Number out of bounds, or the previous number is greater!!!");
        }
    }
}
