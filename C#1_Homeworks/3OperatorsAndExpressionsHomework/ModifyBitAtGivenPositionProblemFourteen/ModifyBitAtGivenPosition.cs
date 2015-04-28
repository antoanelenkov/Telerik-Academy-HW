using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
//at the position p from the binary representation of n while preserving all other bits in n.

namespace ModifyBitAtGivenPositionProblemFourteen
{
    class ModifyBitAtGivenPosition
    {
        static void Main(string[] args)
        {
            int number = 5343;
            byte bitValue = 0;
            int possition = 7;
            int changedNumber = number >> possition;

            //Example:
            //n	    binary      representation of n	    p	 v	  binary       result	      result
            //5343	00010100    11011111	            7	 0	  00010100     01011111	      5215

            if(bitValue==1&&changedNumber%2==1){//If the bit value is "1" and the bit at possition "possition" is "1", there is no need to change the number             
                Console.WriteLine("Result is \"{0}\":",number);
            }

            if (bitValue == 1 && changedNumber % 2 == 0)//If the bit value is "1" and the bit at possition "possition" is "0", there is need to change the number
            {
                double utilityNumber = Math.Pow(2, (possition));//these calculations come from the nature of binary numbers
                number = number + Convert.ToInt32(utilityNumber);
                Console.WriteLine("Result is \"{0}\":", number);
            }

            if (bitValue == 0 && changedNumber % 2 == 1)//If the bit value is "0" and the bit at possition "possition" is "1", there is need to change the number
            {
                double utilityNumber = Math.Pow(2, (possition));//these calculations come from the nature of binary numbers
                number = number - Convert.ToInt32(utilityNumber);
                Console.WriteLine("Result is \"{0}\":", number);
            }

            if (bitValue == 0 && changedNumber % 2 == 0)//If the bit value is "0" and the bit at possition "possition" is "0", there is no need to change the number
            {                
                Console.WriteLine("Result is \"{0}\":", number);
            }

        }
    }
}
