using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[] { "asad", "saddsdsadasdsa", "asd", "asdasfggasfsdsadasdasdasdsa" };
            var longestString = list.OrderByDescending(x => x).First();
            Console.WriteLine("All strings are:\n{0}", String.Join(Environment.NewLine, list));
            Console.WriteLine("The longest string is: {0}", longestString);
        }
    }
}
