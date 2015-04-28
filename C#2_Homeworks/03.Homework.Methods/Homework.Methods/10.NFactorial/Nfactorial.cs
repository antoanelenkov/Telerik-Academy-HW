using System;
using System.Numerics;

/*
Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

class Nfactorial
{
    //With iterations
    static BigInteger FindNFactoriel(int n)
    {
        BigInteger nFactoriel = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactoriel *= i;
        }
            return nFactoriel;
    }

    //With recursion. Check Nakov's book for more information about this method. 
    /*static BigInteger FindNFactoriel(int n)
    {
        BigInteger Nfactoriel=1;
        if (n == 0)
        {
            return 1;
        }
        return n*FindNFactoriel(n - 1);
    }*/

    static void Main()
    {
        Console.Write("Enter number between 1 and 100:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}!: {1}", n, FindNFactoriel(n));
    }
}