namespace Concurrency
{
    using _01.NorthwindDbContextCreating;
    using System.Linq;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            using(NorthwindEntities db1 = new NorthwindEntities())
            {
                using (NorthwindEntities db2 = new NorthwindEntities())
                {
                    var employee1 = db1.Customers.First();
                    employee1.CompanyName = "Name1";

                    var employee2 = db2.Customers.First();
                    employee2.CompanyName = "Name2";

                    db1.SaveChanges();
                    db2.SaveChanges();
                }
            }
        }
    }
}
