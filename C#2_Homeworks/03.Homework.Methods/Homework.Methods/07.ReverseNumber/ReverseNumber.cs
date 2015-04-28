using System;
using System.Collections;
using System.Text;

//Write a method that reverses the digits of given decimal number.

class ReverseNumber
{
    static string ConvertToReverseNumber(long number)
    {
        while (number % 10 == 0)
        {
            number /= 10;
        }
        int numberLength = Convert.ToString(number).Length;
        StringBuilder reverseNumber = new StringBuilder();
        for (int i = 0; i < numberLength; i++)
        {
            reverseNumber.Append(Convert.ToString(number % 10));
            number = number / 10;
        }
        return reverseNumber.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal number:");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("The reverse number is: {0}", ConvertToReverseNumber(number));
    }
}

