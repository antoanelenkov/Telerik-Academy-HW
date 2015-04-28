using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//•	Write a program that reads a text file containing a list of strings, sorts them
//  and saves them to another text file.

class SaveSortedNames
{
    static void Main()
    {
        using(var reader=new StreamReader("List.txt"))
        {
            var list = new List<string>();
        string line=reader.ReadLine();
        while (line != null)
        {
            list.Add(line);
            line = reader.ReadLine();
        }
        list.Sort();
        using (var writer = new StreamWriter("SortedList.txt"))
        {
            foreach (var item in list)
            {
                writer.WriteLine(item);
            }
        }
        }
    }
}

