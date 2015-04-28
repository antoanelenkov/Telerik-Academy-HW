using System;
using System.Diagnostics;

namespace _07.Timer
{
    class Test
    {
        public static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            Timer testTimer = new Timer(2);
            stopwatch.Start();
            testTimer.ExecuteMethod(CertainMethod);

        }

        public static void CertainMethod()
        {
            Console.WriteLine("{0} seconds elapsed",stopwatch.ElapsedMilliseconds/1000);
        }
    }
}
