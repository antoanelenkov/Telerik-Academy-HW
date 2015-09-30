namespace TraverseDir
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;

    class Program
    {
        private const string DirectoriesPath = "..//..//..//01.XMLCatalogue//Directories.xml";
        private const string DirToTraverse = "D:\\Antoan\\Telerik Academy\\Telerik-Academy-HW\\DSA_Homeworks\\03.Homework.TreeAndTraversals";
        private const string UnauthorizedDirToTraverse = "D:\\Antoan\\Telerik Academy\\Telerik-Academy-HW\\DSA_Homeworks\\";

        static void Main()
        {
            /*Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
            Use tags <file> and <dir> with appropriate attributes.
            For the generation of the XML document use the class XmlWriter.*/
            using(XmlTextWriter writer=new XmlTextWriter(DirectoriesPath,Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                writer.WriteStartDocument();
                writer.WriteStartElement("Directories");
                TraverseDirDFSWithRecursion(DirToTraverse,writer);
                writer.WriteEndDocument();
            }

        }

        private static void TraverseDirDFSWithRecursion(string directory,XmlTextWriter writer)
        {
            Console.WriteLine(directory);

            var dirs = Directory.GetDirectories(directory);

            foreach (var dir in dirs)
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", dir);
                TraverseDirDFSWithRecursion(dir, writer);
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


    }
}
