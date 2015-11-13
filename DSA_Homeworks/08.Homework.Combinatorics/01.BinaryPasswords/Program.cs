using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BinaryPasswords
{
    class Program
    {
        private static int counter = 0;

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var possiblePaths = new char[] { '0', '1' };
            var stars = 0;
            long allPossibles = 1;

            foreach (var item in input)
            {
                if (item == '*')
                {
                    allPossibles *= 2;
                    stars++;
                }
            }

            Console.WriteLine(allPossibles);
            //Console.WriteLine(VariationsWithRepetitions(possiblePaths, 0, possiblePaths.Length, stars));
        }

        // 60 points in BGcoder
        private static int VariationsWithRepetitions(char[] arr, int index, int n, int k)
        {
            if (index >= k)
            {
                return ++counter;
            }

            for (int i = 0; i < n; i++)
            {
                var count = VariationsWithRepetitions(arr, index + 1, n, k);
                counter = count;
            }

            return counter;
        }
    }
}
