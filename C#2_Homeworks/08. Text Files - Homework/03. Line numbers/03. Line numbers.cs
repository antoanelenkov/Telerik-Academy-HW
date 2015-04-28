using System;
using System.IO;
using System.Text;

//•	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//•	The result should be written to another text file.

class LineNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("Windows-1251")))
        {
            string line = reader.ReadLine();
            using (StreamWriter writer = new StreamWriter("test2.txt"))
            {
                int count = 1;
                while (line != null)
                {
                    line = reader.ReadLine();
                    writer.WriteLine("{0}.{1}", count, line);
                    count++;
                }
            }               
        }
    }
}

