using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_05.Northwind
{
    public static class DataGenerator
    {
        public static IList<Customer> GetData()
        {
            List<Customer> list = new List<Customer>();
            for (int i = 0; i < 20; i++)
            {
                Customer cust = new Customer();
                cust.FirstName = "FirstName" + (i + 1);
                cust.LastName = "LastName" + (i + 1);
                cust.Age = 10 + i;
                list.Add(cust);
            }

            return list;
        }
    }
}