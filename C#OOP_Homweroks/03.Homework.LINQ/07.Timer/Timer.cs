using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace _07.Timer
{
    public delegate void myDelegate();

    class Timer
    {
        private int interval;

        public Timer(int interval)
        {
            this.interval = interval;
        }

        public int Interval
        {
            set { this.interval = value; }
        }
        
        public string ExecuteMethod(myDelegate currentDelegate)
        {
            while (true)
            {
                currentDelegate();
                Thread.Sleep(this.interval*1000);
            }
        }

    }
}
