using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to hexadecimal numbers (directly).


    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number in binary format:");
            string binarylNumber = Console.ReadLine();
            Console.WriteLine("This number in hexadecimal format is:");
            Console.WriteLine(ConvertBinaryToHex(binarylNumber));
        }

        static string ConvertBinaryToHex(string binaryNumber)
        {
            long decimalNumber = 0;
            int degree = binaryNumber.Length - 1;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                decimalNumber += (binaryNumber[i] - 48) * (long)(Math.Pow(2, degree));
                degree--;
            }
            return ConvertDecimalToHex(decimalNumber);
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
                    hexadecimal = (char)(currentSymbol-10+'A') + hexadecimal;
                    number /= 16;
                } 
            }

            return hexadecimal;
        }
    }

