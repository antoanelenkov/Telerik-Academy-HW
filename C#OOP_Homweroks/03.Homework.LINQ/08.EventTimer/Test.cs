using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace _08.EventTimer
{
    class Test
    {
        public static Stopwatch stopwatch = new Stopwatch();

        static void Main(string[] args)
        {
            Timer testTimer = new Timer(2);
            testTimer.TimeElapsed += CertainMethod;
            stopwatch.Start();
            testTimer.ExecuteMethod();

        }

        public static void CertainMethod(object sender,EventArgs evetnArgs)
        {
            Console.WriteLine("{0} seconds elapsed", stopwatch.ElapsedMilliseconds / 1000);
        }
    }
}
