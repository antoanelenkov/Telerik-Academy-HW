using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Boolean expression that returns if the bit at 
//position p (counting from 0, starting from the right) in given integer number n, has value of 1.

namespace CheckBitAtGivenPositionProblemThirteen
{
    class CheckBitAtGivenPosition
    {
        static void Main(string[] args)
        {

            int n = 5343;
            int p = 7;
            int changedNumber = n >> p;
            if (changedNumber % 2 == 1)//If that is true, "0" possition's bit will be "1".
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
