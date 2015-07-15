using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Contintents.Models;
using System.Data.Entity;
using Contintents.Models.Tables;

namespace Continents.Repos.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<DBWebContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        int days = (DateTime.Now.Month - DateTime.Now.Month) > 0 ? (DateTime.Now.Month - DateTime.Now.Month) : (-DateTime.Now.Month + DateTime.Now.Month);

        protected override void Seed(DBWebContext context)
        {
            this.LoadLanguages(context);
            this.LoadContinents(context);
            this.LoadCountries(context);
            this.LoadTowns(context);
        }

        private void LoadLanguages(DBWebContext context)
        {
            if (!context.Languages.Any())
            {
                context.Languages.Add(new Language { Name = "English"});
                context.Languages.Add(new Language { Name = "USA" });
                context.Languages.Add(new Language { Name = "Bulgarian" });
                context.Languages.Add(new Language { Name = "German"});
                context.SaveChanges();
            }
        }

        private void LoadTowns(DBWebContext context)
        {
            if (!context.Towns.Any())
            {
                context.Towns.Add(new Town { Name = "Sofia", Country = context.Countries.FirstOrDefault(x => x.Name == "Bulgaria") });
                context.Towns.Add(new Town { Name = "Pazardzhik", Country = context.Countries.FirstOrDefault(x => x.Name == "Bulgaria") });
                context.Towns.Add(new Town { Name = "Varna", Country = context.Countries.FirstOrDefault(x => x.Name == "Bulgaria") });
                context.Towns.Add(new Town { Name = "Boston", Country = context.Countries.FirstOrDefault(x => x.Name == "USA") });
                context.Towns.Add(new Town { Name = "Texas", Country = context.Countries.FirstOrDefault(x => x.Name == "USA") });
                context.Towns.Add(new Town { Name = "Las Vegas", Country = context.Countries.FirstOrDefault(x => x.Name == "USA") });
            }
        }

        private void LoadContinents(DBWebContext context)
        {
            if (!context.Continents.Any())
            {
                context.Continents.Add(new Continent { Name = "Africa" });
                context.Continents.Add(new Continent { Name = "Europe" });
                context.Continents.Add(new Continent { Name = "South America" });
                context.Continents.Add(new Continent { Name = "North America" });
                context.SaveChanges();
            }
        }

        private void LoadCountries(DBWebContext context)
        {
            if (!context.Countries.Any())
            {
                context.Countries.Add(new Country
                {
                    Name = "Bulgaria",
                    Continent = context.Continents.FirstOrDefault(x => x.Name == "Europe"),
                    population = 25252,
                    Towns = context.Towns.Where(x => x.Name == "Pazardzhik" || x.Name == "Sofia" || x.Name == "Varna").ToList()
                });
                context.Countries.Add(new Country
                {
                    Name = "USA",
                    Continent = context.Continents.FirstOrDefault(x => x.Name == "North America"),
                    population = 123213,
                    Towns = context.Towns.Where(x => x.Name == "Boston" || x.Name == "Texas" || x.Name == "Las Vegas").ToList()
                });
                //test for unkonwn cities
                context.Countries.Add(new Country
                {
                    Name = "Invalid Country",
                    Continent = context.Continents.FirstOrDefault(x => x.Name == "North America"),
                    population = 121473213,
                    Towns = new List<Town>{new Town{Name="Invalid City"}}
                });
                context.SaveChanges();
            }
        }

    }
}
