using _01.NorthwindDbContextCreating;

namespace CustomersOperations.DAOs
{

    interface ICustmoerDAO
    {
        bool Add(Customer customer);

        bool Modify(Customer customer);

        bool Delete(Customer customer);     
    }
}
