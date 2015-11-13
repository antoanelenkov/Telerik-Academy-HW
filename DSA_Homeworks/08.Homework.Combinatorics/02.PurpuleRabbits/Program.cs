using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PurpuleRabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var rabbits = new Dictionary<int, int>();

            for (int i = 0; i < number; i++)
            {
                var current = int.Parse(Console.ReadLine());
                if (!rabbits.ContainsKey(current))
                {
                    rabbits.Add(current, 1);
                }
                else
                {
                    rabbits[current]++;
                }
            }

            var result = 0;
            foreach (var item in rabbits)
            {
                var multiplier = (item.Value / (item.Key+1));
                if (item.Value % (item.Key+1 ) > 0)
                {
                    multiplier += 1;
                }
                result += (item.Key+1) * multiplier;
            }

            Console.WriteLine(result);
        }
    }
}
