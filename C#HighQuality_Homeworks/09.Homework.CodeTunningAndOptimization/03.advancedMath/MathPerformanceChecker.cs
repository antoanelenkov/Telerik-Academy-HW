namespace advancedMath
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public static class PerformanceChecker
    {
        private const int NUMBER_OF_LOOPS = 100000;

        private static Stopwatch stopWatch = new Stopwatch();

        internal static void CheckPerformance(double value, Operator typeOfOperator)
        {
            dynamic result = 10;

            switch (typeOfOperator)
            {
                case Operator.SquareRoot:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        value = Math.Sqrt(value);
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for square root: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                case Operator.NaturalLogarithm:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        value = Math.Log(value);
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for natural logarithm: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                case Operator.Sinus:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        value = Math.Sin(value);
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for sinus: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                default:
                    break;
            }
        }
    }
}
