namespace MusicSystem.Data
{
    using Contracts;
    using System.Data.Entity;
    using System.Linq;

    class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        public GenericRepository() : this(new MusicSystemDbContext())
        {
        }

        public GenericRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<T>();
        }

        protected IDbSet<T> DbSet { get; set; }

        protected DbContext Context { get; set; }

        public void Add(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Added);
        }

        public IQueryable<T> All()
        {
            return this.DbSet.AsQueryable();
        }

        public void Delete(int id)
        {
            var entity = this.Find(id);

            if (entity != null)
            {
                this.Delete(entity);
            }
        }

        public void Delete(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Deleted);
        }

        public void Detach(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Detached);
        }

        public T Find(object id)
        {
            return this.DbSet.Find(id);
        }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Modified);
        }

        private void ChangeEntityState(T entity, EntityState newEntityState)
        {
            var entry = this.Context.Entry(entity);
            entry.State = newEntityState;
        }
    }
}
