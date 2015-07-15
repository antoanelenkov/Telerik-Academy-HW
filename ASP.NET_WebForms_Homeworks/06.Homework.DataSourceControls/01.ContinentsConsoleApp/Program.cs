using Continents.Repos;
using Contintents.Models;
using Contintents.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ContinentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db=new DBUnitOfWork();

            var language=new Language
            {              
                Name="Englishhh",
                LanguageId=1
            };

            db.Languages.Add(language);
            db.SaveChanges();


            foreach (var item in db.Languages.All())
            {
                Console.WriteLine(item);
            }
        }
    }
}
