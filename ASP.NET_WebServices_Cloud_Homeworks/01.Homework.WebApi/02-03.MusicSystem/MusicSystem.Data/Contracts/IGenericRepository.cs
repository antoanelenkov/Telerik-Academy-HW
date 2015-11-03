using System.Linq;

namespace MusicSystem.Data.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> All();      

        T Find(object id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Detach(T entity);

        void SaveChanges();
    }
}
