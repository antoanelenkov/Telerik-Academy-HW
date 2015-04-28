using System;
using System.Numerics;

/*
Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */

class NumberAsArray
{
    static BigInteger AddTwoNumbers(BigInteger a, BigInteger b)
    {
        BigInteger result = 0;
        int lengthOfA = Convert.ToString(a).Length;
        int lengthOfB = Convert.ToString(b).Length;
        int lengthOfArray = (lengthOfA > lengthOfB ? lengthOfA : lengthOfB);
        BigInteger[] arrayA = new BigInteger[lengthOfArray];
        BigInteger[] arrayB = new BigInteger[lengthOfArray];

        for (int i = 0; i < lengthOfArray; i++)
        {
            arrayA[i] = 0;
            arrayB[i] = 0;
        }
        for (int i = lengthOfArray - Math.Max(lengthOfA, lengthOfB); i < lengthOfArray; i++)
        {
            arrayA[i] = a % 10;
            a /= 10;
        }

        for (int i = lengthOfArray - Math.Max(lengthOfA, lengthOfB); i < lengthOfArray; i++)
        {
            arrayB[i] = b % 10;
            b /= 10;
        }

        for (int i = 0; i < lengthOfArray; i++)
        {
            result += (((arrayA[i] + arrayB[i]) % 10) * (BigInteger)(Math.Pow(10, i)));
            if (arrayA[i] + arrayB[i] > 10)
            {
                result += (BigInteger)(Math.Pow(10, i + 1));
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter the first number:");
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("The number after adding the prevous two is: {0}", AddTwoNumbers(a, b));
    }
}

