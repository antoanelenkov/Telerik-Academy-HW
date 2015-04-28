using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to their decimal representation.


class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in binary format:");
        string binarylNumber = Console.ReadLine();
        Console.WriteLine("This number in decimal format is:");
        Console.WriteLine(ConvertBinaryToDecimal(binarylNumber));
    }

    static long ConvertBinaryToDecimal(string binaryNumber)
    {
        long decimalNumber = 0;
        int degree = binaryNumber.Length - 1;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += (binaryNumber[i]-48) * (long)(Math.Pow(2, degree));
            degree--;
        }

        return decimalNumber;
    }
}

