namespace _03.BiDictionary
{
    using System;

    class EntryPoint
    {
        static void Main(string[] args)
        {
            var biDictionary = new BiDictionary<string, string, string>();

            Console.WriteLine(biDictionary.Add("one", "edno", "0000001"));
            Console.WriteLine(biDictionary.Add("two", "dve", "0000010"));
            Console.WriteLine(biDictionary.Add("three", "tri", "0000100"));

            Console.WriteLine(biDictionary.Contains("one"));
            Console.WriteLine(biDictionary.Contains("edno"));

            Console.WriteLine(biDictionary.GetValue("dve"));
            Console.WriteLine(biDictionary.GetValue("two"));
        }
    }
}
