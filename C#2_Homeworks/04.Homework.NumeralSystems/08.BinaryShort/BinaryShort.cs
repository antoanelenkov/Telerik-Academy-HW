using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).



class BinaryShort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in decimal format(-32,768 to 32,767):");
        short decimalNumber = short.Parse(Console.ReadLine());
        Console.WriteLine("This number in binary format is:");
        Console.WriteLine(ConvertDecimalToBinary(decimalNumber));
    }

    static string ConvertDecimalToBinary(short number)
    {
        string binary = "";

        if (number >= 0)
        {
            while (number > 0)
            {
                string currentSymbol = (number % 2).ToString();
                binary = currentSymbol + binary;
                number /= 2;
            }
            for (int i = binary.Length; i < 16; i++)
            {
                if (i == 15)
                {
                    binary = "(0)" + binary;
                }
                else
                {
                    binary = "0" + binary;
                }
            }
            return binary;
        }
        else
        {
            int newNumber = 32768 + number;
            string newBinary = ConvertDecimalToBinary((short)newNumber);
            for (int i = newBinary.Length; i < 16; i++)
            {
                if (i == 15)
                {
                    newBinary = "(1)" + newBinary;
                }
                else
                {
                    newBinary = "0" + newBinary;
                }
            }
            return newBinary;
        }

    }
}

