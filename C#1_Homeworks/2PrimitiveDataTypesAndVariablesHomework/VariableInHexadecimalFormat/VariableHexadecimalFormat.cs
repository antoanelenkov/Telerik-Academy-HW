using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

namespace VariableInHexadecimalFormat
{
    class VariableHexadecimalFormat
    {
        static void Main(string[] args)
        {
            
          int valueInDecimal=254;
          string hexOutput = String.Format("{0:X}", valueInDecimal);//Find the value in Hex.
          Console.WriteLine(hexOutput);//Print 254=FE in Hex and after that I use it in the line bellow this one.
          int valueInHex=0xFE;
          Console.WriteLine(valueInHex);
          

        }
    }
}
