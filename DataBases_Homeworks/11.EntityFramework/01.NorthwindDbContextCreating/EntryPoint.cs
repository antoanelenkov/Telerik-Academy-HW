namespace NorthwindDbContextCreating
{
    using _01.NorthwindDbContextCreating;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            NorthwindEntities dbContext = new NorthwindEntities();

            System.Console.WriteLine(dbContext.Products.FirstOrDefault().ProductName);
            System.Console.WriteLine("It's connected!");
        }
    }
}
