using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare five variables choosing for each of them the most appropriate of the types
//byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.

namespace DeclareVariablesProblemOne
{
    class DeclareVariablesProblemOne
    {
        static void Main(string[] args)
        {
            byte numberByte = 97;
            Console.WriteLine(numberByte);
            sbyte numberSByte = -115;
            Console.WriteLine(numberSByte);
            ushort numberUShort = 52130;
            Console.WriteLine(numberUShort);
            short numberShort = -10000;
            Console.WriteLine(numberShort);      
            int numberInt = 4825932;
            Console.WriteLine(numberInt);
        }
    }
}
