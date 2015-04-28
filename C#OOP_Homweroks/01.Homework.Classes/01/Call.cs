using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class Call
    {
        private DateTime date;
        private string dialedPhone;
        private int seconds;

        public Call(DateTime date, string dialedPhone, int seconds)
        {
        this.Date=date;
        this.DialedPhone=dialedPhone;
        this.Seconds=seconds;
        }
      
        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (seconds >= 0)
                {
                    this.seconds = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("The value for seconds must be non-negative value.");
                }
            }
                
        }
        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set
            {
                if (value[0] == '+')
                {
                    this.dialedPhone = value;
                }
                else
                {
                    throw new FormatException("the first sign of the phone number must be \"+\"");
                }
            }
        }
        public DateTime Date
        {
            set {this.date = value; }
            get { return this.date; }
        }

        public override string ToString()
        {
            return String.Format("Date: {0}\n" +
                                "Time: {1}\n" +
                                "Dialed phone: {2}\n" +
                                "Seconds: {3}\n",
                                this.date.ToString("dd/MM/yy"), this.date.ToString("HH:mm:ss"), this.dialedPhone, this.seconds);
        }     
    }
}
