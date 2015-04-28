using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
*/



namespace ProblemFive
{
    class FormattingNumbers
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer in the range from 0 to 500:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a float number:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter a float number:");
            float c = float.Parse(Console.ReadLine());
            string convertToBinary = Convert.ToString(a, 2);        
            Console.WriteLine("||{0:x3}        ||{1}||{2,10:F2}||{3,-10:F3}||", a, convertToBinary, b, c);           
        }


//DON'T READ BELLOW!
//This is method for converting a decimal number  in binary format. 
//We haven't learnt methods yet as well as notations in programming, that's why I decided to put it in method outside the "main" body.

        static string ConvertToBinary(int number)
        {
            sbyte counter = 0;
            int[] helpArrayForBinaryValues = new int[9];
            int[] ArrayForBinaryValues = new int[9];
            while (number / 2 >= 0)
            {
                helpArrayForBinaryValues[counter] = number % 2;
                number /= 2;
                counter++;
                if ((number / 2 == 0) && (number % 2 == 0))
                {
                    break;
                }
            }

            for (int i = 0, j = helpArrayForBinaryValues.Length - 1; i < helpArrayForBinaryValues.Length; i++, j--)
            {
                ArrayForBinaryValues[i] = helpArrayForBinaryValues[j];
            }
            string result = string.Join("", ArrayForBinaryValues);
            return result;
        }

    }
}
