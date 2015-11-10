using System;
using System.Collections.Generic;
using System.Text;

namespace Jedai
{
    struct Program
    {
        static void Main()
        {
            var countOfJedis = int.Parse(Console.ReadLine());
            var allJedis = Console.ReadLine();
            var pCollection = new List<string>(100000);
            var kCollection = new List<string>(100000);
            var result = new StringBuilder();

            for (int i = 0; i < allJedis.Length; i++)
            {
                if (allJedis[i] != 'm' && allJedis[i] != 'k' && allJedis[i] != 'p')
                {
                    continue;
                }

                var indexOfSpace = allJedis.IndexOf(' ', i);
                if (indexOfSpace == -1)
                {
                    indexOfSpace = allJedis.Length;
                }
                switch (allJedis[i])
                {
                    case 'p': pCollection.Add(allJedis.Substring(i, indexOfSpace - i)); break;
                    case 'k': kCollection.Add(allJedis.Substring(i, indexOfSpace - i)); break;
                    case 'm': result.AppendFormat("{0} ",allJedis.Substring(i, indexOfSpace - i)); break;
                    default: break;
                }
            }

            for (int i = 0; i < kCollection.Count; i++)
            {
                result.AppendFormat("{0} ",kCollection[i]);
            }

            for (int i = 0; i < pCollection.Count; i++)
            {
                result.AppendFormat("{0} ", pCollection[i]);
            }

            Console.WriteLine(result);
        }
    }
}
