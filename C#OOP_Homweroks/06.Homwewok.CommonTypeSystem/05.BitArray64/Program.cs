namespace BitArray64
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            BitArray64 number1 = new BitArray64(5);
            BitArray64 number2 = new BitArray64(5);
            Console.WriteLine(String.Join("",number1.BitArray));

            //Test indexer
            Console.WriteLine(number1[0]);
            number1[3] = 1;

            //Test Equals
            Console.WriteLine(number1 == number2);

            //Test "=="
            Console.WriteLine(number1.Equals(number2));

            //Test enumerator
            foreach (var item in number1)
            {
                Console.Write(item);
            }

            //Test GetHashCode
            Console.WriteLine(number1.GetHashCode());
            Console.WriteLine(number1.GetHashCode());
        }
    }
}
