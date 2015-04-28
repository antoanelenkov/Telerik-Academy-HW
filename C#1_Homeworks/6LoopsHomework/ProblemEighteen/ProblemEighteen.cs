using System;
using System.Numerics;

//•	Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//•	Your program should work well for very big numbers, e.g. n=100000.

class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        BigInteger zeroes = n / 5;//The zeroes depends on that when you divide by 5, the result will be the number of "0"
        Console.WriteLine("trailing zeroes of a n! are: "+zeroes);
    }
}

