using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

//•	Modify the solution of the previous problem to replace only whole words (not strings).

class ReplaceWholeWord
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
                    line = Regex.Replace(line, "\\bstart\\b", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
                Console.WriteLine("Fin!");
            }
        }
    }
}

