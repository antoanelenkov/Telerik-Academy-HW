using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).


class OneSystemToAnyOther
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose numeral system from which you want to convert(from 2 to 16):");
        int startFormat = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose numeral system in which you want to convert(from 2 to 16):");
        int endFormat = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number in [{0}] numeral format:",startFormat);
        string baseNumber = Console.ReadLine();
        //Console.WriteLine(ConvertBaseToDecimal(baseNumber, startFormat) != -1 ? "This number in decimal format is: {0}" :
        //    "There is no such number!", ConvertBaseToDecimal(baseNumber, startFormat));
        Console.WriteLine("This number in [{0}] format is:", endFormat);
        Console.WriteLine(ConvertDecimalToOtherFormat(ConvertBaseToDecimal(baseNumber, startFormat), endFormat));
    }

    static long ConvertBaseToDecimal(string baseNumber, int startFormat)
    {
        long decimalN = 0;
        int degree = baseNumber.Length - 1;
        for (int i = 0; i < baseNumber.Length; i++)
        {
            if (baseNumber[i] >= 48 && baseNumber[i] < 59)
            {
                decimalN += (char)(baseNumber[i] - '0') * (long)(Math.Pow(startFormat, degree));
                degree--;
            }
            else
            {
                if (baseNumber[i] >= 65 && baseNumber[i] < 65 + 6)
                {
                    decimalN += (char)(baseNumber[i] + 10 - 'A') * (long)(Math.Pow(startFormat, degree));
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

    static string ConvertDecimalToOtherFormat(long number, int endFormat)
    {
        string endFormatSystem = "";
        while (number > 0)
        {
            long currentSymbol = number % endFormat;
            if ((number % endFormat) < 10)
            {
                endFormatSystem = currentSymbol.ToString() + endFormatSystem;
                number /= endFormat;
            }
            else
            {
                endFormatSystem = (char)(currentSymbol-10+'A') + endFormatSystem;
                number /= endFormat;
            }         
        }
        return endFormatSystem;
    }
}

