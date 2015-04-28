using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two positive integer numbers 
//and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

namespace ProblemEleven
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for the start number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for the end number:");
            int p = int.Parse(Console.ReadLine());
            int counter = 0;          
            int range=Math.Abs(n-p);

            for(int i=0;i<range;i++)
            {
                if((n<=p)){
                    if (n % 5 == 0){                     
                    counter++;
                    }
                    n++;                 
                }
                if ((n >= p))
                {
                    if (p % 5 == 0)
                    {
                        counter++;
                    }
                    p++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
