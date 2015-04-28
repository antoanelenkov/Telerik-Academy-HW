using System;
using System.IO;
using System.Text;

//•	Write a program that extracts from given XML file all the text without the tags.

class ExtractTextFromXML
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("XML.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                bool startPrint = false;
                foreach (var symbol in line)
                {
                    if (startPrint&&symbol!='<')
                    {
                        Console.Write(symbol);
                    }
                    if (symbol == '>')
                    {
                        startPrint = true;
                    }
                    if (symbol == '<')
                    {
                        startPrint = false;
                    }
                }
                    Console.WriteLine();               
                line = reader.ReadLine();
            }
        }
    }
}

