using System;

/*
•	Using loops write a program that converts a binary integer number to its decimal form.
•	The input is entered as string. The output should be a variable of type long.
•	Do not use the built-in .NET functionality.
*/

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter binary number:");
        string binaryString = Console.ReadLine();
        long binaryLong = long.Parse(binaryString);
        double currentNumber = 0;
        int sum = 0;

        for (int i = 0; i < binaryString.Length; i++)
        {
            currentNumber=binaryLong % 10 * Math.Pow(2, i);
            sum += (int)currentNumber;
            binaryLong /= 10;
        }
        Console.WriteLine("The decimal number is:" + sum);

    }
}

