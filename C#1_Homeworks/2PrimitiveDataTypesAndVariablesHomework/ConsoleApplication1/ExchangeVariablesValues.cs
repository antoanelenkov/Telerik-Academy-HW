using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.


namespace ConsoleApplication1
{
    class ExchangeVariablesValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before exchange");
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            int c = a;//this variable help us for exchanging the values of "a" & "b".
            a = b;
            b = c;
            Console.WriteLine("After exchange");
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
         
        }
    }
}
