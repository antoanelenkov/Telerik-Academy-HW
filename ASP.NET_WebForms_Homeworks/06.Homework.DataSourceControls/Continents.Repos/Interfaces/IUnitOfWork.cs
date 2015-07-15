namespace Continents.Repos.Interfaces
{
    using Contintents.Models;
    using Contintents.Models.Tables;

    public interface IUnitOfWork
    {
        IGenericRepo<Country> Countries { get; }

        IGenericRepo<Town> Towns { get; }

        IGenericRepo<Continent> Continents { get; }

        IGenericRepo<Language> Languages { get; }

        void SaveChanges();
    }
}
