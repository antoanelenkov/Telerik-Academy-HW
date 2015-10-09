namespace CustomersOperations.DAOs
{
    using System;
    using _01.NorthwindDbContextCreating;
    using System.Data.Entity;
    using System.Linq;

    class CustomersDAO : ICustmoerDAO
    {


        public bool Add(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                var customerIdToAdd = customer.CustomerID;
                var customerToAdd = db.Customers.FirstOrDefault(x => x.CustomerID == customerIdToAdd);

                db.Customers.Attach(customer);

                if(customerToAdd==null)
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();

                    return true;
                }
            }

            return true;
        }

        public bool Delete(Customer customer)
        {
            using (var db = new NorthwindEntities())
            {
                var customerIdToDelete = customer.CustomerID;
                var customerToDelete = db.Customers.FirstOrDefault(x => x.CustomerID == customerIdToDelete);
                if (customerToDelete == null)
                {
                    return false;
                }

                //1.SQL query
                //string query = string.Format("DELETE FROM Customers WHERE CustomerID = '{0}'", customerIdToDelete);
                //var resultFromDb=db.Database.ExecuteSqlCommand(query);
                //if (resultFromDb == 0)
                //{
                //    return false;
                //}


                //2.Regular scenario
                db.Customers.Remove(customerToDelete);
                var resultFromDb = db.SaveChanges();
                if (resultFromDb == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public bool Modify(Customer customer)
        {        
               
            using (var db = new NorthwindEntities())
            {
                var customerToModify = db.Customers.FirstOrDefault(x => x.CustomerID == customer.CustomerID);

                if (customerToModify == null)
                {
                    return false;
                }

                customer.Address = customerToModify.Address;
                customer.City = customerToModify.City;

                db.SaveChanges();
            }

            return true;
        }
    }
}
