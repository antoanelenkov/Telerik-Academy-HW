using System;

//•	Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//•	Use the Euclidean algorithm (find it in Internet).

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number:");
        double a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double b = int.Parse(Console.ReadLine());
        int greatestDivisor=0;
        if (Math.Abs(a) > Math.Abs(b))
        {
            for (int i = 1; i < Math.Abs(a); i++)
            {
                if (a % i == 0 && b % i == 0 && i > greatestDivisor)
                {
                    greatestDivisor = i;
                }
            }
            Console.WriteLine(greatestDivisor);
        }
        else
        {
            for (int i = 1; i < Math.Abs(b); i++)
            {
                if (a % i == 0 && b % i == 0 && i > greatestDivisor)
                {
                    greatestDivisor = i;
                }
            }
            Console.WriteLine("The greatest common divisor is:"+greatestDivisor);
        }
        

    }
}

