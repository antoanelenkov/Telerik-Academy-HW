using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

namespace BitExchangeForAdvancedProblemSicteen
{
    class BitExchangeForAdvanced
    {
        static void Main(string[] args)
        {
            int number = 28;
            int startPossitionOne = 3;
            int startPossitionTwo = 6;
            int range =3;
            string[] arrayOne = new string[32];

            for (int i = 31; i >= 0; i--)
            {
                arrayOne[i] = Convert.ToString(number % 2);
                number /= 2;
            }

            Console.WriteLine("The number before the exchange looks like:");
            for (int i = 0; i < 32; i++)
            {
                Console.Write(arrayOne[i]);
            }
            Console.WriteLine();

            for (int i = 32 - startPossitionOne; i > 32 - startPossitionOne - range; i--)
            {
                string a = arrayOne[i];
                arrayOne[i] = arrayOne[32-startPossitionTwo];
                arrayOne[32 - startPossitionTwo] = a;
                startPossitionTwo++;
            }

            Console.WriteLine("The number after the exchange looks like:");
            for (int i = 0; i < 32; i++)
            {
                Console.Write(arrayOne[i]);
            }
            Console.WriteLine();
        }
    }
}
