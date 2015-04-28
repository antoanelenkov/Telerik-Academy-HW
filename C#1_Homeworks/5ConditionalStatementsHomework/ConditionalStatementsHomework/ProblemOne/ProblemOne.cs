using System;

//Write an if-statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class ExchangeIFGreater
{
    static void Main()
    {    
        Console.WriteLine("Enter value for a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for b");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine(b + " " + a);
        }
    }
}