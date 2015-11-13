namespace _04.ColorBalls
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var chars = input.ToCharArray();

            var dict = new Dictionary<char, int>();
            foreach (var @char in chars)
            {
                if (dict.ContainsKey(@char))
                {
                    dict[@char]++;
                }
                else
                {
                    dict.Add(@char, 1);
                }
            }

            // The formula for "AAABBC" is: (6)!/(3!+2!+1!) [6-All, 3-A, 2-B, C-1]
            BigInteger result = GetFactoriel(chars.Length);
            foreach (var item in dict)
            {
                result /= GetFactoriel(item.Value);
            }

            Console.WriteLine(result);
        }

        private static BigInteger GetFactoriel(int number)
        {
            BigInteger result = 1;

            for (int i = number; i > 0; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}
