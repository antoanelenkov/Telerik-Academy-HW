using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _08.EventTimer
{
    class Timer:TimerEvent
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

        public void ExecuteMethod()
        {
            while (true)
            {
                this.EventHappened();
                Thread.Sleep(this.interval * 1000);
            }
        }
    }
}
