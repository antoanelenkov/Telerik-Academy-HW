namespace ExtractPrices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        private const string Path = "..//..//..//01.XMLCatalogue//Catalogue.xml";

        static void Main()
        {
            /*10. Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
            Use XPath query.*/
            XmlDocument doc10 = new XmlDocument();
            doc10.Load(Path);
            string query = String.Format("/catalogue/album[year<={0}]",DateTime.Now.Year-5);
            var albumsFiveYearsEarlier = doc10.SelectNodes(query);

            Console.WriteLine("XPath:");
            foreach (XmlNode node in albumsFiveYearsEarlier)
            {
                Console.WriteLine(node["name"].InnerText);
            }

            /*11. Rewrite the previous using LINQ query.*/
            XDocument doc11 = XDocument.Load(Path);
            var albums = doc11.Descendants("album");

            var names = from album in albums
                        where int.Parse(album.Element("year").Value) < (DateTime.Now.Year - 5)
                        select album.Element("name").Value;
           
            Console.WriteLine("LINQ:\n"+String.Join("\n", names));
        }
    }
}
