namespace SimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    internal class MathTester
    {
        public static void Main()
        {
            int integerValue = 1;
            long longValue = 1;
            float floatVale = 1.1f;
            double doubleValue = 1.1;
            decimal decimalValue = 1.0m;

            // Integer test
            Console.WriteLine("Integer:");
            MathPerformanceChecker.CheckPerformance(integerValue, Operator.Add);
            MathPerformanceChecker.CheckPerformance(integerValue, Operator.Subtract);
            MathPerformanceChecker.CheckPerformance(integerValue, Operator.Multiply);
            MathPerformanceChecker.CheckPerformance(integerValue, Operator.Devide);
            MathPerformanceChecker.CheckPerformance(integerValue, Operator.Increment);
            Console.WriteLine();

            // Long test
            Console.WriteLine("Long:");
            MathPerformanceChecker.CheckPerformance(longValue, Operator.Add);
            MathPerformanceChecker.CheckPerformance(longValue, Operator.Subtract);
            MathPerformanceChecker.CheckPerformance(longValue, Operator.Multiply);
            MathPerformanceChecker.CheckPerformance(longValue, Operator.Devide);
            MathPerformanceChecker.CheckPerformance(longValue, Operator.Increment);
            Console.WriteLine();

            // Float test
            Console.WriteLine("Float:");
            MathPerformanceChecker.CheckPerformance(floatVale, Operator.Add);
            MathPerformanceChecker.CheckPerformance(floatVale, Operator.Subtract);
            MathPerformanceChecker.CheckPerformance(floatVale, Operator.Multiply);
            MathPerformanceChecker.CheckPerformance(floatVale, Operator.Devide);
            MathPerformanceChecker.CheckPerformance(floatVale, Operator.Increment);
            Console.WriteLine();

            // Double test
            Console.WriteLine("Double:");
            MathPerformanceChecker.CheckPerformance(doubleValue, Operator.Add);
            MathPerformanceChecker.CheckPerformance(doubleValue, Operator.Subtract);
            MathPerformanceChecker.CheckPerformance(doubleValue, Operator.Multiply);
            MathPerformanceChecker.CheckPerformance(doubleValue, Operator.Devide);
            MathPerformanceChecker.CheckPerformance(doubleValue, Operator.Increment);
            Console.WriteLine();

            // Double test
            Console.WriteLine("Decimal:");
            MathPerformanceChecker.CheckPerformance(decimalValue, Operator.Add);
            MathPerformanceChecker.CheckPerformance(decimalValue, Operator.Subtract);
            MathPerformanceChecker.CheckPerformance(decimalValue, Operator.Multiply);
            MathPerformanceChecker.CheckPerformance(decimalValue, Operator.Devide);
            MathPerformanceChecker.CheckPerformance(decimalValue, Operator.Increment);
            Console.WriteLine();
        }
    }
}
