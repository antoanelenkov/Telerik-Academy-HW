using System.Collections.Generic;
using System.Xml;

namespace DeleteAlbums
{
    class Program
    {
        private const string Path = "..//..//..//01.XMLCatalogue//Catalogue.xml";
        private const string UpdatedFilePath = "..//..//..//01.XMLCatalogue//UpdatedCatalogue.xml";
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path);
            var root = doc.DocumentElement;
            var albums = doc.GetElementsByTagName("album");
            var albumsToDelete = new List<XmlNode>();

            foreach (XmlNode album in root.ChildNodes)
            {
                if (double.Parse(album["price"].InnerText) > 20)
                {
                    albumsToDelete.Add(album);
                }
            }

            foreach (var album in albumsToDelete)
            {
                root.RemoveChild(album);
                System.Console.WriteLine("Album '{0}' has been removed", album["name"].InnerText);
            }

            doc.Save(UpdatedFilePath);

        }
    }
}
