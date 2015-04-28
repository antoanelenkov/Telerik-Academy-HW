using System;
using System.Numerics;

//•	In combinatorics, the Catalan numbers are calculated by the following formula:  
//•	Write a program to calculate the nth Catalan number by given n (1 < n < 100).



    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n:");
            int n = int.Parse(Console.ReadLine());
            
            BigInteger factorialOne = 1;
            BigInteger factorialTwo = 1;
            BigInteger factorialThree = 1;

            for (int i = 2*n; i > 0; i--)
            {
                factorialOne *= i;
            }
            for (int i =  n; i > 0; i--)
            {
                factorialTwo *= i;
            }
            for (int i = n+1; i > 0; i--)
            {
                factorialThree *= i;
            }
           
            Console.WriteLine("2n!/(2n!(n+1)!)=" + factorialOne / (factorialTwo*factorialThree));
        }
    }

