namespace advancedMath
{
    using System;

    internal class MathTester
    {
        public static void Main()
        {
            float floatVale = 1.1f;
            double doubleValue = 1.1d;
            decimal decimalValue = 1.1m;

            // Double test
            Console.WriteLine("Double:");
            PerformanceChecker.CheckPerformance(doubleValue, Operator.SquareRoot);
            PerformanceChecker.CheckPerformance(doubleValue, Operator.NaturalLogarithm);
            PerformanceChecker.CheckPerformance(doubleValue, Operator.Sinus);
            Console.WriteLine();

            // Float test
            Console.WriteLine("Float:");
            PerformanceChecker.CheckPerformance(floatVale, Operator.SquareRoot);
            PerformanceChecker.CheckPerformance(floatVale, Operator.NaturalLogarithm);
            PerformanceChecker.CheckPerformance(floatVale, Operator.Sinus);
            Console.WriteLine();

            // Decimal test
            Console.WriteLine("Decimal:");
            PerformanceChecker.CheckPerformance((double)decimalValue, Operator.SquareRoot);
            PerformanceChecker.CheckPerformance((double)decimalValue, Operator.NaturalLogarithm);
            PerformanceChecker.CheckPerformance((double)decimalValue, Operator.Sinus);
            Console.WriteLine();
        }
    }
}
