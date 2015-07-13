namespace Class_123
{
    using System;

    public class Printer
    {
        const int MAX_COUNT = 6;

        public static void Main()
        {
            Printer.BoolPrinter sampleObject = new Printer.BoolPrinter();

            sampleObject.PrintConvertedString(true);
        }

        public class BoolPrinter
        {
            public void PrintConvertedString(bool input)
            {
                string boolToString = input.ToString();

                Console.WriteLine(boolToString);
            }
        }
    }
}
