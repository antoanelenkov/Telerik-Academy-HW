using System;

//Write a program that finds the biggest of five numbers by using only five if statements.

class TheBiggestOfFiveNumbers

    //Write a program that finds the biggest of three numbers.
{
    static void Main()
    {
        Console.WriteLine("Enter value for the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the third number:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the fourth number:");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the fifth number:");
        int e = int.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(@"The biggest number is""a""");
        }
        if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(@"The biggest number is""b""");
        }
        if (c > a && c > b && c > d && c > e)
        {
            Console.WriteLine(@"The biggest number is""c""");
        }
        if (d > a && d > b && d > c && d > e)
        {
            Console.WriteLine(@"The biggest number is""d""");
        }
        if (e > a && e > b && e > c && e > d)
        {
            Console.WriteLine(@"The biggest number is""e""");
        }
    }
}