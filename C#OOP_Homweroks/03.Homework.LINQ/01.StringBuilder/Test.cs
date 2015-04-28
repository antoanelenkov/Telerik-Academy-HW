using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implement an extension method Substring(int index, int length) for the class StringBuilder 
 * that returns new StringBuilder and has the same functionality as Substring in the class String.*/

namespace LINQ
{
    class Test
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("Some text here");
            Console.WriteLine(sb.GetSubString(3,67));
        }
    }
}
