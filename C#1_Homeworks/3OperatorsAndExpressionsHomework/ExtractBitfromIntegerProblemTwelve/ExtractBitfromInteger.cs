using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that extracts from given integer n the value of given bit at index p.

namespace ExtractBitfromIntegerProblemTwelve
{
    class ExtractBitfromInteger
    {
        static void Main(string[] args)
        {
            int n = 5343;
            int p = 7;
            int changedNumber = n >> p;
            if (changedNumber % 2 == 1)//If that is true, "0" possition's bit will be "1".
            {
                Console.WriteLine("The bit at possition \"{0}\"  is \"1\".", p);
            }
            else
            {
                Console.WriteLine("The bit at possition \"{0}\"  is \"0\".", p);
            }
        }
    }
}
