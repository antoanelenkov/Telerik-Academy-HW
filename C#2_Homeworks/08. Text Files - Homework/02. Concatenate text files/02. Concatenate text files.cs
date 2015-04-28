using System;
using System.IO;
using System.Text;

//•	Write a program that concatenates two text files into another text file.

class ConcatenateTextFiles
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("result.txt"))
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\test.txt", Encoding.GetEncoding("Windows-1251")))
            {

                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            using (StreamReader reader = new StreamReader(@"..\..\..\test2.txt", Encoding.GetEncoding("Windows-1251")))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }     
    }
}
