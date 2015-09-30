namespace Person
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class Program
    {
        private const string TxtPath = "..//..//..//01.XMLCatalogue//Person.txt";
        private const string XmlPath = "..//..//..//01.XMLCatalogue//Person.xml";

        static void Main()
        {
            /*In a text file we are given the name, address and phone number of given person(each at a single line).
            Write a program, which creates new XML document, which contains these data in structured XML format.*/
            string name;
            string phone;
            string adress;

            using (StreamReader reader = new StreamReader(TxtPath))
            {
                name = reader.ReadLine();
                phone = reader.ReadLine();
                adress = reader.ReadLine();
            }

            XElement personDoc = new XElement("person",new XElement("name", name),new XElement("phone", phone),new XElement("adress", adress));

            personDoc.Save(XmlPath);
            Console.WriteLine("Person has been saved in: "+XmlPath);
        }
    }
}
