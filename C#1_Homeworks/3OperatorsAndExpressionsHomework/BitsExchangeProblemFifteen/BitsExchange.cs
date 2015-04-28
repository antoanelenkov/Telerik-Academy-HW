using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

namespace BitsExchangeProblemFifteen
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            int number = 28;
            string[] arrayOne = new string[32];

            for (int i = 31; i >= 0 ; i--)
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

            for (int i = 29; i > 26; i--)
            {
                string a=arrayOne[i];
                arrayOne[i] = arrayOne[i-21];
                arrayOne[i - 21] = a;
            }
            Console.WriteLine("The number before the exchange looks like:");            
            for (int i = 0; i < 32; i++)
            {
                Console.Write(arrayOne[i]);
            }
            Console.WriteLine();
            
        }
    }
}
