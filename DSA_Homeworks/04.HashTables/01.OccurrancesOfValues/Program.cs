using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OccurrancesOfValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new double[]{3, 4, 4, -2.5, 3, 3, 4, 3, -2.5};
            var dictionary = new Dictionary<double, int>();

            foreach (var number in array)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }
                dictionary[number]++;
            }

            foreach (var number in dictionary)
            {
                Console.WriteLine(number.Key + " -> " + number.Value + (number.Value == 1 ? " time" : " times"));
            }
        }
    }
}
