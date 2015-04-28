using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

class MultiplicationSignn
{
    static void Main()
    {
        Console.WriteLine("Enter value for the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for the third number:");
        int c = int.Parse(Console.ReadLine());
        while (true)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0"); break;
            }
            if (((a < 0 || b < 0 || c < 0) && ((a > 0 && b > 0) || (b > 0 && c > 0) || (c > 0 && a > 0))) || (a < 0 && b < 0 && c < 0))
            {
                Console.WriteLine("-"); break;
            }
            else
            {
                Console.WriteLine("+"); break;
            }
        }
    }
}