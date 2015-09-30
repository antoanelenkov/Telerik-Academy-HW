namespace ExtractSongsTitle
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        private const string Path = "..//..//..//01.XMLCatalogue//Catalogue.xml";

        static void Main()
        {
            //05.Write a program, which using XmlReader extracts all song titles from catalog.xml.
            using (XmlReader reader = XmlReader.Create(Path))
            {
                Console.WriteLine("Using XmlReader:");

                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }

            //06.Rewrite the same using XDocument and LINQ query.
            var doc = XDocument.Load(Path);
            var albums = doc.Descendants("album");

            var songs = from title in albums.Descendants("title") select title.Value;

            Console.WriteLine("\nUsing XDocument and LINQ:\n"+String.Join("\n", songs));           
        }
    }
}
