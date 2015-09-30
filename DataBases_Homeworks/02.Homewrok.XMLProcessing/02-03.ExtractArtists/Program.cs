namespace ExtractArtists
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using Wintellect.PowerCollections;

    class Program
    {
        private const string Path = "..//..//..//01.XMLCatalogue//Catalogue.xml";
        static void Main()
        {
            /* 02.Write program that extracts all different artists which are found in the catalog.xml.
            For each author you should print the number of albums in the catalogue.
            Use the DOM parser and a hash - table.*/
            var artists = new Dictionary<string, int>();

            XmlDocument doc = new XmlDocument();
            doc.Load(Path);
            var root = doc.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "artist")
                    {
                        if (artists.ContainsKey(child.InnerText))
                        {
                            var count = artists[child.InnerText];
                            artists[child.InnerText] = ++count;
                        }
                        else
                        {
                            artists.Add(child.InnerText, 1);
                        }
                    }
                }
            }

            Console.WriteLine("NOT using XPath:\n" + String.Join(", ", artists));


            //03. Implement the previous using XPath.
            string query = "/catalogue/album/artist";
            var artistsNodes = doc.SelectNodes(query);
            var uniqueArtists = new HashSet<string>();

            foreach (XmlNode node in artistsNodes)
            {
                uniqueArtists.Add(node.InnerText);
            }

            Console.WriteLine("Using XPath:\n" + String.Join(", ", uniqueArtists));
        }
    }
}
