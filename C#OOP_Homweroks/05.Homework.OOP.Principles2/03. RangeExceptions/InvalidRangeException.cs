using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(string message,T start, T end) : base(message+String.Format("Lower bound: {0}, Upper bound: {1}",start,end))
        {
            this.start = start;
            this.end = end;
        }

        public InvalidRangeException(string msg, T start, T end, Exception innerEx)
            : base(msg, innerEx)
        {
            this.start = start;
            this.end = end;
        }

        public T Start { get; set; }
        public T End { get; set; }
    }
}
