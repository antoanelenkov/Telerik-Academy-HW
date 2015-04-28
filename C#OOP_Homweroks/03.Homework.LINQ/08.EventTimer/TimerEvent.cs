using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EventTimer
{
    public delegate void ChangedEventHandler(object sender, EventArgs e);

    class TimerEvent
    {
        public event ChangedEventHandler TimeElapsed;

        protected virtual void EventHappened()
        {
            if (this.TimeElapsed != null)
            {
                this.TimeElapsed(this,EventArgs.Empty);
            }
        }
    }
}
