using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace PrintSequenceProblemNine
{
    class PrintSequence
    {
        static void Sequence()
        { }

        static void Main(string[] args)
        {
            int evenNumber = 2;
            int oddNumber = -3;
            for (int i = 0; i < 5; i++)//With this loop we will print exactly 5*2=10 numbers from the sequence we want.
            {            
                Console.Write("{0}, ",evenNumber);

                if (i == 4) //4 is the number for "i" for the last loop, where after the last number we don't need ",".
                {
                    Console.Write("{0}", oddNumber); break;
                }

                Console.Write("{0}, ", oddNumber);
                evenNumber = evenNumber + 2;
                oddNumber = oddNumber - 2;
            }
            Console.WriteLine();
        }
    }
}
