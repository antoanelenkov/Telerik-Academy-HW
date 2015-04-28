using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

//•	Write a program that deletes from a text file all words that start with the prefix test.
//•	Words contain only the symbols 0…9, a…z, A…Z, _.

class PrefixTest
{
    static void Main()
    {
        var list = new List<string>();
        using (StreamReader reader = new StreamReader("Prefix.txt", Encoding.GetEncoding("Windows-1251")))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] words = line.Split(' ');
                foreach (var word in words)
                {
                    if (word.Contains("test") && word.Length==4)
                    {
                        list.Add(word);
                    }
                    if (!word.Contains("test"))
                    {
                        list.Add(word);
                    }
                }
                line = reader.ReadLine();
                list.Add(Convert.ToString('-'));//Add random char symbol except of "A-Z","a-z" and "0-9", which I will use to go on the next line of the text file.
            }
        }

        using (StreamWriter writer = new StreamWriter("Prefix2.txt"))
        {
            foreach (var item in list)
            {
                char sym;
                if (char.TryParse(item,out sym))//Here I use the char symbol.
                {
                    writer.WriteLine();
                    continue;
                }
                writer.Write(item+" ");
            }
        }
        Console.WriteLine("Fin!");

    }
}

