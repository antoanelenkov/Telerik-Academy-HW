using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class Test
    {
        static void Main(string[] args)
        {

            var date1 = new DateTime(1979, 1, 1);
            var dateStartRange = new DateTime(1980, 1, 1);
            var dateEndRange = new DateTime(2013, 12, 31);
            if (date1 > dateStartRange && date1 < dateEndRange)
            {
                throw new InvalidRangeException<DateTime>("The date is out of range: ", dateStartRange, dateEndRange);
            }

            var number = 98;
            var numberStartRange = 0;
            var numberEndRange = 100;
            if (number > numberStartRange && number < numberEndRange)
            {
                throw new InvalidRangeException<int>("The date is out of range: ", numberStartRange, numberEndRange);
            }
        }
    }
}
