
using System.Data.Entity;
using Contintents.Models;
using Continents.Repos.Migrations;
using Contintents.Models.Tables;

namespace Continents.Repos
{
    public class DBWebContext:DbContext
    {
        public DBWebContext()
            : base("WorldDBContext")
        {         
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DBWebContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<DbContext>());
        }

        public IDbSet<Country> Countries { get; set; }
        public IDbSet<Town> Towns { get; set; }
        public IDbSet<Language> Languages { get; set; }
        public IDbSet<Continent> Continents { get; set; }

        public static DBWebContext Create()
        {
            return new DBWebContext();
        }
    }
}
