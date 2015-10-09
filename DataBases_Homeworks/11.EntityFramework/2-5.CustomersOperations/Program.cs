using _01.NorthwindDbContextCreating;
using CustomersOperations.DAOs;
using System;
using System.Linq;

namespace CustomersOperations
{
    class Program
    {
        static void Main()
        {
            var customerDAO = new CustomersDAO();
            var randomGenerator = new Random();
            var randomId = randomGenerator.Next().ToString().Substring(0, 5);

            AddCustomer(customerDAO, "1");
            DeleteCustomer(customerDAO);
            ModifyCustomer(customerDAO);
            AttachCustomer();
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

            Console.WriteLine("Customer changes saved: " + (result > 0 ? "True" : "False"));
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
