namespace Continents.Repos
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;

    using Continents.Repos.Interfaces;
    using Continents.Repos.Repositories;
    using Contintents.Models.Tables;
    using Contintents.Models;


    public class DBUnitOfWork:IUnitOfWork
    {
        static void Main(string[] args)
        {
            //do nothing
        }

        private readonly DbContext context;
        private readonly IDictionary<Type, object> repositories;

        public DBUnitOfWork()
            :this(new DBWebContext())
        {
        }

        public DBUnitOfWork(DbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }


        public IGenericRepo<Country> Countries
        {
            get
            {
                return this.GetRepository<Country>();
            }
        }

        public IGenericRepo<Town> Towns
        {
            get
            {
                return this.GetRepository<Town>();
            }
        }

        public IGenericRepo<Continent> Continents
        {
            get
            {
                return this.GetRepository<Continent>();
            }
        }

        public IGenericRepo<Language> Languages
        {
            get
            {
                return this.GetRepository<Language>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IGenericRepo<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericWebRepo<T>);
                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepo<T>)this.repositories[typeOfModel];
        }
    }
}
