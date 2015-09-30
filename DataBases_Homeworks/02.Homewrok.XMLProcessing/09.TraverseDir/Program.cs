namespace TraverseDir
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        private const string DirectoriesPath9 = "..//..//..//01.XMLCatalogue//Directories9.xml";
        private const string DirectoriesPath10 = "..//..//..//01.XMLCatalogue//Directories10.xml";
        private const string DirToTraverse = "D:\\Antoan\\Telerik Academy\\Telerik-Academy-HW\\DSA_Homeworks\\03.Homework.TreeAndTraversals";
        private const string UnauthorizedDirToTraverse = "D:\\Antoan\\Telerik Academy\\Telerik-Academy-HW\\DSA_Homeworks\\";

        static void Main()
        {
            /*09. Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
            Use tags <file> and <dir> with appropriate attributes.
            For the generation of the XML document use the class XmlWriter.*/
            using (XmlTextWriter writer = new XmlTextWriter(DirectoriesPath9, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                writer.WriteStartDocument();
                writer.WriteStartElement("Directories");
                TraverseDirAndWriteWithXmlTextWriter(DirToTraverse, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("Categories9.xml has been generated. It's path is: {0}", DirectoriesPath9);

            //Rewrite the last exercises using XDocument, XElement and XAttribute.
            XElement root = new XElement("directories");
            TraverseDirAndWriteWithXDocument(DirToTraverse, root);
            root.Save(DirectoriesPath10);

            Console.WriteLine("Categories10.xml has been generated. It's path is: {0}", DirectoriesPath10);
        }

        private static void TraverseDirAndWriteWithXDocument(string directory, XElement element)
        {
            var dirs = Directory.GetDirectories(directory);

            try
            {
                foreach (var dir in dirs)
                {
                    XAttribute pathAttribute = new XAttribute("path", dir);
                    XElement dirElement = new XElement("dir", pathAttribute);
                    TraverseDirAndWriteWithXDocument(dir, dirElement);
                    element.Add(dirElement);
                }

                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    XAttribute pathAttribute = new XAttribute("path", Path.GetFileName(file));
                    XElement dirElement = new XElement("file", pathAttribute);
                    element.Add(dirElement);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }

        private static void TraverseDirAndWriteWithXmlTextWriter(string directory, XmlTextWriter writer)
        {
            var dirs = Directory.GetDirectories(directory);

            try
            {
                foreach (var dir in dirs)
                {
                    writer.WriteStartElement("dir");
                    writer.WriteAttributeString("path", dir);
                    TraverseDirAndWriteWithXmlTextWriter(dir, writer);
                    writer.WriteEndElement();
                }

                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    writer.WriteStartElement("file");
                    writer.WriteAttributeString("path", Path.GetFileName(file));
                    writer.WriteEndElement();
                }
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }


    }
}
