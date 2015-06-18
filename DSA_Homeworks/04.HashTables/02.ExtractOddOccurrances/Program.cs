using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExtractOddOccurrances
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]{"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 0;
                }
                dictionary[word]++;
            }

            foreach (var word in dictionary)
            {
                if (word.Value % 2 == 1)
                {
                    Console.WriteLine(word.Key + " -> " + word.Value + (word.Value == 1 ? " time" : " times"));
                }
            }
        } 
    }
}
