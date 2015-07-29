namespace SimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading.Tasks;

    public class MathPerformanceChecker
    {
        private const int NUMBER_OF_LOOPS = 100000;

        private static Stopwatch stopWatch = new Stopwatch();

        public static void CheckPerformance<T>(T value, Operator typeOfOperator)
        {
            dynamic result = 1;

            switch (typeOfOperator)
            {
                case Operator.Add:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        result += value;
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for adding: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                case Operator.Multiply:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        result *= value;
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for multipling: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                case Operator.Increment:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        result += 1;
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for incrementing: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                case Operator.Subtract:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        result /= value;
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for subtracting: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                case Operator.Devide:
                    stopWatch.Start();
                    for (int i = 0; i < NUMBER_OF_LOOPS; i++)
                    {
                        result /= value;
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Time elapsed for dividing: " + stopWatch.Elapsed);
                    stopWatch.Reset();
                    break;
                default:
                    break;
            }
        }
    }
}
