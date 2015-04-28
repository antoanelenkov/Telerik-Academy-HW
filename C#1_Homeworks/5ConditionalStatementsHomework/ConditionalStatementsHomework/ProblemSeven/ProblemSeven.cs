using System;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Note: Don’t use arrays and the built-in sorting functionality.

class SortThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the third number:");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c && b > c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        else
        {
            if (a > b && a > c && b < c)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
        if (b > a && b > c && a > c)
        {
            Console.WriteLine(b + " " + a + " " + c);
        }
        else
        {
            if (b > a && b > c && a < c)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        if (c > a && c > b && a > b)
        {
            Console.WriteLine(c + " " + a + " " + b);
        }
        else
        {
            if (c > a && c > b && a < b)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }

    }
}