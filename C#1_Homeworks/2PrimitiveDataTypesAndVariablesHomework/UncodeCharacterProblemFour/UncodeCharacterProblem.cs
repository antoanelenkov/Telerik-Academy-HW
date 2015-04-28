using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//clare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

namespace UncodeCharacterProblemFour
{
    class UncodeCharacterProblem
    {
        static void Main(string[] args)
        {
          int valueInDecimal=42;
          string hexOutput = String.Format("{0:X}", valueInDecimal);//Find the value in Hex.
          Console.WriteLine(hexOutput);//Print 42=2A in Hex and after that I use it in the line bellow this one.
          char symbol='\u002A';
          Console.WriteLine(symbol);


        }
    }
}
