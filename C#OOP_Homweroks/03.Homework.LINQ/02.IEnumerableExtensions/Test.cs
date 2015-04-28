using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Test
    {
        static void Main()
        {
            IEnumerable<double> arr = new double[] { 2.5, 15.5, 20.5 };
            Console.WriteLine("The max value is:");
            Console.WriteLine(arr.Max());
            Console.WriteLine("The min value is:");
            Console.WriteLine(arr.Min());
            //Use numeric types for sum.
            Console.WriteLine("The sum is:");
            Console.WriteLine(arr.Sum());
            //Use numeric types for product.
            Console.WriteLine("The product is:");
            Console.WriteLine(arr.Product());
            //Use numeric types for average.
            Console.WriteLine("The average value is:");
            Console.WriteLine(arr.Average());
        }
    }
}
