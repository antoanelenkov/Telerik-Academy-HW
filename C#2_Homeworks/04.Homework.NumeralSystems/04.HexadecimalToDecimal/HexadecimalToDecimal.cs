using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).


class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in hexaDecimal format:");
        string hex = Console.ReadLine();
        Console.WriteLine(ConvertHexToDecimal(hex) != -1 ? "This number in decimal format is: {0}" : "There is no such number!", ConvertHexToDecimal(hex));
    }

    static long ConvertHexToDecimal(string hexNumber)
    {
        long decimalN = 0;
        int degree = hexNumber.Length - 1;
        for (int i = 0; i < hexNumber.Length; i++)
        {
            if (hexNumber[i] >= 48 && hexNumber[i] < 59)
            {
                decimalN += (char)(hexNumber[i] - '0') * (long)(Math.Pow(16, degree));
                degree--;
            }
            else
            {
                if (hexNumber[i] >= 65 && hexNumber[i] < 65 + 6)
                {
                    decimalN += (char)(hexNumber[i] + 10 - 'A') * (long)(Math.Pow(16, degree));
                    degree--;
                }
                else
                {
                    return -1;
                }
            }

        }

        return decimalN;
    }
}

