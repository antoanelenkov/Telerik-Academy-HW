using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.


namespace ProblemFive
{
    class CalculateSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for for n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for for x:");
            int x = int.Parse(Console.ReadLine());
            double sum = 0;
            int a=1;
            double b=0;

            for (int i = 1; i <= n; i++)
            {
                a*=i;
                b=Math.Pow((double)x,(double)i);
                sum += ((double)a)/b;
            }
            Console.WriteLine("The sum is:{0:f5}", sum+1);
        }
    }
}
