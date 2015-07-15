using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_05.Northwind
{
    public class Customer
    {
        private string fullname;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName+' '+LastName; }
            set { fullname = value; }
        }
        public int Age { get; set; }
        
    }
}