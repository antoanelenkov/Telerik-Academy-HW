using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

namespace BitwiseProblemEleven
{
    class Bitwise
    {
        static void Main(string[] args)
        {
            int number = 8;
            int changedNumber = number >> 3;//Move the 3rd bit at "0" possition possition.
            Console.WriteLine(changedNumber);
            if (changedNumber % 2 == 1)//If that is true, "0" possition's bit will be "1".
            {
                Console.WriteLine("The 3rd bit is \"1\"");
            }
            else
            {
                Console.WriteLine("The 3rd bit is \"0\"");
            }
        }
    }
}
