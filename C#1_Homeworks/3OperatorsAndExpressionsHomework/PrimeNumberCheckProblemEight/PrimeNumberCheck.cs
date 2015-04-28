using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given positive integer number n (n = 100) 
//is prime (i.e. it is divisible without remainder only to itself and 1).

namespace PrimeNumberCheckProblemEight
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            int number = 100;
            int counter=2;

            while (counter < Math.Sqrt(number))//It is easier with "for" cycle, but this is just another way to solve the problem.

            {
                if (number % counter == 0)
                {
                    Console.WriteLine("Number \"{0}\" is not prime", number);  break;
                }
                counter++;
            }
            if (counter > Math.Sqrt(number))
            {
                Console.WriteLine("Number \"{0}\" is prime", number);
            }         
        }
    }
}
