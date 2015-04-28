using System;
using System.IO;
using System.Text;

/*•	Write a program that replaces all occurrences of the sub-string start with 
 *  the sub-string finish in a text file.
  •	Ensure it will work with large files (e.g. 100 MB).*/

class ReplaceSubString
{
    static void Main()
    {
        using (var reader = new StreamReader("start.txt"))
        {
            string line = reader.ReadLine();
            using (var writer = new StreamWriter("final.txt"))
            {
                while (line != null)
                {
                    line = line.Replace("start", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
                Console.WriteLine("Fin!");
            }
        }
    }
}

