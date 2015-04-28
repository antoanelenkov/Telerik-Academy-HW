using System;

//•	Using loops write a program that converts an integer number to its binary representation.
//•	The input is entered as long. The output should be a variable of type string.
//•	Do not use the built-in .NET functionality.

class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number in decimal format:");
        long decimalFormat = long.Parse(Console.ReadLine());
        string[] binaryArray = new string[32];
        int counter = 31;

        while (decimalFormat / 2 > 0 || (decimalFormat / 2 == 0 && decimalFormat % 2 != 0))
        {
            binaryArray[counter] = ""+decimalFormat % 2;
            decimalFormat /= 2;
            counter--;
        }
        for (int i = 0; i < binaryArray.Length; i++)
        {
            Console.Write(binaryArray[i]);
        }
        Console.WriteLine();
            
    }
}

