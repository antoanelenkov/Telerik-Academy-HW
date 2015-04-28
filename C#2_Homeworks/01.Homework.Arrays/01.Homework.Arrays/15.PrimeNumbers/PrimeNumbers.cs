using System;
using System.Diagnostics;

/*Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.*/

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for the range of the cheked numbers: ");
            int upperBound = int.Parse(Console.ReadLine());
            bool[] is_prime = new bool[upperBound + 1];

            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 2; i < upperBound + 1; i++)
            {
                is_prime[i] = true;
            }

            for (int i = 2; i <= upperBound; i++)
            {
                if (is_prime[i])
                {
                    for (int j = i * 2; j <= upperBound; j += i)
                    {
                        is_prime[j] = false;
                    }
                }
            }
            Console.WriteLine("Prime numbers are:");
            for (int i = 2; i <= upperBound - 1; i++)
            {
                if (is_prime[i])
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            watch.Stop();
            Console.WriteLine("Time for calculating is {0}ms. ", watch.ElapsedMilliseconds);


            //There is my second way for solving the problem. Check out if you want. In the end of every solved problem, there is the time needed to solve it.
            Stopwatch.StartNew();
            Console.WriteLine("SECOND METHOD:");
            Console.WriteLine("Prime numbers are:");
            Console.Write(2 + " ");
            Console.Write(3 + " ");
            for (int i = 2; i < upperBound + 1; i++)
            {
                int temp = 0;
                for (int j = 2; j < Math.Pow((double)i, .5); j++)
                {
                    if (i % j != 0)
                    {
                        temp = j;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                if (temp > Math.Pow((double)i, .5) - 1)
                {

                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
            watch.Stop();
            Console.WriteLine("Time for calculating is {0}ms. ", watch.ElapsedMilliseconds);
        }
    }
}
