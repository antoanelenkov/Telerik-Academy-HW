using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a console application that prints the current date and time. Find out how in Internet.

namespace ConsoleApplication7
{
    class CurrentDateAndTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0:HH:mm:ss tt}", DateTime.Now)); //google it for more info
        }
    }
}
