namespace _CreateXSLandTransformToHTML
{
    using System.Xml.Xsl;

    class Program
    {
        private const string XmlPath = "..//..//..//01.XMLCatalogue//Catalogue.xml";
        private const string XslPath = "..//..//..//01.XMLCatalogue//Catalogue.xslt";
        private const string HtmlPath = "..//..//..//01.XMLCatalogue//Catalogue.html";
        static void Main()
        {
            /*13. Create an XSL stylesheet, which transforms the file catalog.xml into HTML document, 
            formatted for viewing in a standard Web-browser.*/
            //Done: "..//..//..//01.XMLCatalogue//Catalogue.xml"


            /*14. Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml using the class XslTransform.*/
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load(XslPath);
            xslt.Transform(XmlPath, HtmlPath);
            System.Console.WriteLine("Html genereted in {0}: ", HtmlPath);
        }
    }
}
