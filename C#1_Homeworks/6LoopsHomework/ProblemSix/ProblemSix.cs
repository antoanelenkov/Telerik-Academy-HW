using System;

//•	Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//•	Use only one loop.



class CalculateFactoriel
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
        int factorial = 1;

        for (int i = n; i > n - difference; i--)
        {
            factorial *= i;
        }
        Console.WriteLine("n!/k!=" + factorial);
    }
}

