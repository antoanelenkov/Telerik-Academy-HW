using System;

//Write a program that finds the biggest of three numbers.

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the third number:");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(@"The biggest number is""a""");
        }
        if (b > a && b > c)
        {
            Console.WriteLine(@"The biggest number is""b""");
        }
        if (c > a && c > b)
        {
            Console.WriteLine(@"The biggest number is""c""");
        }
    }
}