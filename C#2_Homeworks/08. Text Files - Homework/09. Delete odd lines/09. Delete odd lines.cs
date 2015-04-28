using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//•	Write a program that deletes from given text file all odd lines.
//•	The result should be in the same file.

class DeleteOddLines
{
    static void Main()
    {
        var list = new List<string>();

        using (StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("Windows-1251")))
        {
            int lineCounter = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineCounter % 2 != 0)
                {
                    list.Add(line);
                }
                line = reader.ReadLine();
                lineCounter++;
            }
        }

        using (StreamWriter writer = new StreamWriter("test.txt"))
        {
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
        }
        Console.WriteLine("Fin!");
    }
}


