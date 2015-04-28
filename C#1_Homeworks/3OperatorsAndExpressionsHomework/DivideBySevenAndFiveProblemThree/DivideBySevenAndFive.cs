using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

namespace DivideBySevenAndFiveProblemThree
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            int number = 35;
            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("Yes It can be devided by 5 and 7 at the same time");
            }
            else
            {
                Console.WriteLine("No It can not be devided by 5 and 7 at the same time");   
            }
        }
    }
}
