using System;

/*•	Write a program that reads an integer number and calculates and prints its square root.
    o	If the number is invalid or negative, print Invalid number.
    o	In all cases finally print Good bye.
  •	Use try-catch-finally block.*/


class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter number to calculate it's square root:");
        try
        {
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                //This makes the program to work slowly. In this case exception is not needed, but I use it just because of the educational purpose.
                throw new IndexOutOfRangeException();
                //This is the faster way of solving the problem:
                //Console.WriteLine("Non-negative numbers are not allowed!");
                //return;
            }
            double result = Math.Sqrt(number);

            Console.WriteLine("Result is: {0}", result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format entered!");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid number entered! The value must be non-negative!");
        }
        finally
        {
            Console.WriteLine("Good bye :)");
        }
    }
}

