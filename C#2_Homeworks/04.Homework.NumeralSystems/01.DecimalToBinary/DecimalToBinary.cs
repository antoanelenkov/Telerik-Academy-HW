using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.


class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in decimal format:" );
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("This number in binary format is:"    );
        Console.WriteLine(ConvertDecimalToBinary(decimalNumber));
    }

    static string ConvertDecimalToBinary(long number)
    {
        string binary = "";
        while (number > 0)
        {
            string currentSymbol = (number % 2).ToString();
            binary = currentSymbol + binary;
            number /= 2;
        }

        return binary;
    }
}



