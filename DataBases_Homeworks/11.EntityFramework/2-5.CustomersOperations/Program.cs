namespace CustomersOperations
{
    using _01.NorthwindDbContextCreating;
    using DAOs;
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var customerDAO = new CustomersDAO();
            var randomGenerator = new Random();
            var randomId = randomGenerator.Next().ToString().Substring(0, 5);

            // 2.Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
            // Write a testing class.
            AddCustomer(customerDAO, "1");
            DeleteCustomer(customerDAO);
            ModifyCustomer(customerDAO);
            AttachCustomer();

            // 3.Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            FindCustomersByCriteriaUsingLambda();

            // 4.Implement previous by using native SQL query and executing it through the DbContext.
            FindCustomersByCriteriaUsingSqlQuery();

            // 5.Write a method that finds all the sales by specified region and period (start / end dates)
            FindSalesByCriteria("SP", new DateTime(1997, 1, 1), new DateTime(1997, 6, 6));

        }

        private static void FindCustomersByCriteriaUsingSqlQuery()
        {
            using (var db = new NorthwindEntities())
            {
                var query = String.Format("SELECT * FROM Customers, Orders " +
                                "WHERE Customers.CustomerID=Orders.CustomerID " +
                                "AND YEAR(Orders.ShippedDate) = {0} " +
                                "AND Orders.ShipCountry = '{1}'", 1997, "Canada");
                var filteredCustomers = db.Database.SqlQuery<Customer>(query).ToList();


                Console.WriteLine("4. All company names covered the criteria:");
                foreach (var customer in filteredCustomers)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }

        private static void FindCustomersByCriteriaUsingLambda()
        {
            using (var db = new NorthwindEntities())
            {
                var filteredCustomers = db.Orders
                    .Where(o => o.OrderDate.Value.Year == 1997 && o.ShipCountry == "Canada")
                    .Select(c => c.Customer)
                    .ToList();

                Console.WriteLine("3. All company names covered the criteria:");
                foreach (var customer in filteredCustomers)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }

        private static void FindSalesByCriteria(string region, DateTime start,DateTime end)
        {
            using (var db = new NorthwindEntities())
            {
                var filteredOrders = db.Orders
                    .Where(o => o.ShipRegion == region)
                    .Where(o => o.OrderDate > start && o.OrderDate < end)
                    .ToList();

                Console.WriteLine("5. All order's Id by region and dates:");
                foreach (var order in filteredOrders)
                {
                    Console.WriteLine(order.OrderID);
                }
            }
        }

        private static void AttachCustomer()
        {
            var customerToAttach = new Customer
            {
                CustomerID = "ANTON",
                CompanyName = "1"
            };

            var db = new NorthwindEntities();
            db.Customers.Attach(customerToAttach);

            //need to be changed after attaching to save changes.
            customerToAttach.City = "asd";
            var result = db.SaveChanges();

            Console.WriteLine("Customer changes saved after attaching: " + (result > 0 ? "True" : "False"));
        }

        private static void ModifyCustomer(CustomersDAO customerDAO)
        {
            using (var bufferBd = new NorthwindEntities())
            {
                var customerToUpdate = bufferBd.Customers.First();
                customerToUpdate.CompanyName = "Updated";

                var isUpdated = customerDAO.Modify(customerToUpdate);
                Console.WriteLine("Customer is updated: " + isUpdated);
            }
        }

        private static void DeleteCustomer(CustomersDAO customerDAO)
        {
            var customerToDelete = new Customer
            {
                CustomerID = "1"
            };

            var isDeleted = customerDAO.Delete(customerToDelete);
            Console.WriteLine("Customer is deleted: " + isDeleted);
        }

        private static void AddCustomer(CustomersDAO customerDAO, string randomId)
        {
            var customerToAdd = new Customer
            {
                CustomerID = randomId,
                CompanyName = "Added"
            };

            var isAdded = customerDAO.Add(customerToAdd);
            Console.WriteLine("Customer is added: " + isAdded);
        }
    }
}
