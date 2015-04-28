using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.


class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number in decimal format:");
        int decimalNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("This number in hexadecimal format is:");
        Console.WriteLine(ConvertDecimalToHex(decimalNumber));
    }

    static string ConvertDecimalToHex(long number)
    {
        string hexadecimal = "";
        while (number > 0)
        {
            long currentSymbol = number % 16;
            if ((number % 16) < 10)
            {
                hexadecimal = currentSymbol.ToString() + hexadecimal;
                number /= 16;
            }
            else
            {
                switch (currentSymbol)
                {
                    case 10: hexadecimal = "A" + hexadecimal; break;
                    case 11: hexadecimal = "B" + hexadecimal; break;
                    case 12: hexadecimal = "C" + hexadecimal; break;
                    case 13: hexadecimal = "D" + hexadecimal; break;
                    case 14: hexadecimal = "E" + hexadecimal; break;
                    case 15: hexadecimal = "F" + hexadecimal; break;
                    default:break;
                }

                number /= 16;
            }
            /* Second way of solving the problem.
            else
            {
                hexadecimal = (char)(currentSymbol-10+'A') + hexadecimal;
                number /= 16;
            } 
            */

        }

        return hexadecimal;
    }
}

