namespace CreateAlbum
{
    using System;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        private const string CataloguePath = "..//..//..//01.XMLCatalogue//Catalogue.xml";
        private const string AlbumsPath = "..//..//..//01.XMLCatalogue//Albums.xml";
        static void Main()
        {
            /*08. Write a program, which(using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, 
            in which stores in appropriate way the names of all albums and their authors.*/
            using (XmlTextWriter writer=new XmlTextWriter(AlbumsPath,Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 1;
                writer.IndentChar = ' ';

                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create(CataloguePath))
                {
                   while (reader.Read())
                    {
                        if (reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteElementString("name", reader.ReadElementContentAsString());
                        }
                        else if (reader.Name == "artist")
                        {
                            writer.WriteElementString("artist", reader.ReadElementContentAsString());
                            writer.WriteEndElement();
                        }
                    }
                }

                writer.WriteEndElement();
            }


            //-----------------------------XDocument way---------------------------------

            var albums = new XElement("albums");

            using (XmlReader reader = XmlReader.Create(CataloguePath))
            {
                XElement name;
                XElement author;
                var album = new XElement("album");

                while (reader.Read())
                {
                    if (reader.Name == "name")
                    {
                        name = new XElement("name", reader.ReadInnerXml());
                        album.Add(name);
                    }
                    else if (reader.Name == "artist")
                    {
                        author = new XElement("artist", reader.ReadInnerXml());
                        album.Add(author);

                        albums.Add(album);

                        album = new XElement("album");
                    }
                }
            }

            Console.WriteLine(String.Join("\n", albums));

            //albums.Save(AlbumsPath);



        }
    }
}
