using System;
using System.Numerics;

//•	In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
//is calculated by the following formula:   For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//•	Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


namespace ProblemSeven
{
    class CalculateFactorielCombination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for k, which is not greater than \"{0}\":", n);
            int k = int.Parse(Console.ReadLine());

            if (k > n)
            {
                Console.WriteLine("Enter greater value for \"n\" than \"k\" and try again.");
            }
            int difference = Math.Abs(n - k);//Math solution of the problem(Also I need only one loop for the algorithm).
            BigInteger factorial = 1;

            for (int i = n; i > n - difference; i--)
            {
                factorial *= i;
            }
            BigInteger secondFactorial=1;

            for (int i = 1; i <=difference; i++)
            {
                secondFactorial *= i;
            }            
            Console.WriteLine("n!/(k!(n-k)!)=" + factorial / secondFactorial);
        }
    }
}
