namespace _16.XSDSchema
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class Program
    {
        private const string XmlPath = "..//..//..//01.XMLCatalogue//Catalogue.xml";
        private const string XsdPath = "..//..//..//01.XMLCatalogue//Catalogue.xsd";
        private const string XsdNs = "http://www.w3.org/2001/XMLSchema";
        static void Main()
        {
            /*Using Visual Studio generate an XSD schema for the file catalog.xml.
            Write a C# program that takes an XML file and an XSD file (schema) and validates the XML file against the schema.
            Test it with valid XML catalogs and invalid XML catalogs.*/
            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(XsdNs, XsdPath);

            XDocument doc = XDocument.Load(XmlPath);
            string msg = "";
            doc.Validate(schemas, (o, e) => {
                msg += e.Message + Environment.NewLine;
            });
            Console.WriteLine(msg == "" ? "Document is valid" : "Document invalid: " + msg);
        }
    }
}
