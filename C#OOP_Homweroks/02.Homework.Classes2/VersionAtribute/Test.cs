using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    class Test
    {
        static void Main(string[] args)
        {
            var classAttributes = typeof(Matrix).GetCustomAttributes(false);

            foreach (var attr in classAttributes)
            {
                var attribute = (VersionAttribute)attr;
                Console.WriteLine(attribute.Version);
            }
        }
    }
}
