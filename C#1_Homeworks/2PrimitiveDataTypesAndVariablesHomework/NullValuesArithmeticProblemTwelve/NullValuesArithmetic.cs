using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

namespace NullValuesArithmeticProblemTwelve
{
    class NullValuesArithmetic
    {


        static void Main(string[] args)
        {
            int? nullValueVarOne = null;
            double? nullValueVarTwo = null;
            Console.WriteLine(nullValueVarOne);
            Console.WriteLine(nullValueVarTwo);       
        }
    }
}
