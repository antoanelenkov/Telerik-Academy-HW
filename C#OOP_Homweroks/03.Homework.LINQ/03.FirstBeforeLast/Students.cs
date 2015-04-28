using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstBeforeLast
{
    class Students
    {
        public Students(string first, string last,int age)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string result=this.FirstName+" "+this.LastName;
            return result;
        }

    }
}
