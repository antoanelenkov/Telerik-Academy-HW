using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }


    }
}
