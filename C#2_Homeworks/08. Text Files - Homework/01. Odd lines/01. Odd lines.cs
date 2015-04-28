using System;
using System.IO;
using System.Text;


//•	Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\..\test.txt", Encoding.GetEncoding("Windows-1251")))
        {
            int lineCounter=0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineCounter % 2 != 0)
                {
                    Console.WriteLine("{0}.{1}",lineCounter,line);
                }
                line = reader.ReadLine();
                lineCounter++;
            }
        }
    }
}

