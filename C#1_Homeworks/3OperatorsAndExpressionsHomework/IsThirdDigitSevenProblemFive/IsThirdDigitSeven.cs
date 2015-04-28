using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ite an expression that checks for given integer if its third digit from right-to-left is 7.

namespace IsThirdDigitSevenProblemFive
{
    class IsThirdDigitSeven
    {
        static void Main(string[] args)
        {
            int number = 1278798;
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine(@"The third digit from right to left is ""7""");
            }
            else
            {
                Console.WriteLine(@"The third digit from right to left is not ""7""");
            }
            
        }
    }
}
