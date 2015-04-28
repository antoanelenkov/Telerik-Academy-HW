using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Security;

/*•	Write a program that reads a list of words from the file words.txt and finds how
 *  many times each of the words is contained in another file test.txt.
  •	The result should be written in the file result.txt and the words should be 
 *  sorted by the number of their occurrences in descending order.
  •	Handle all possible exceptions in your methods.*/

class CountWords
{
    static void Main()
    {
        try
        {
            using (var writer = new StreamWriter("result.txt"))
            {
                var dictionary = new Dictionary<string, int>();
                foreach (var word in GetListOfWords("list_with_words.txt"))
                {
                    int wordCounter = 0;
                    using (var reader = new StreamReader("text.txt", Encoding.GetEncoding("Windows-1251")))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            string[] wordsInLine = line.Split(new char[] { ' ', '.', ',', '?', '!', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < wordsInLine.Length; i++)
                            {
                                if (wordsInLine[i] == word)
                                {
                                    wordCounter++;
                                }
                            }
                            line = reader.ReadLine();
                        }
                    }
                    dictionary.Add(word, wordCounter);
                }

                var items = from pair in dictionary
                            orderby pair.Value descending
                            select pair;

                foreach (KeyValuePair<string, int> kv in items)
                {
                    writer.WriteLine(kv.ToString());
                }
            }
            Console.WriteLine("Finito!");
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }


    }

    static List<string> GetListOfWords(string path)
    {
        var listOfWords = new List<string>();
        using (var reader = new StreamReader(path, Encoding.GetEncoding("Windows-1251")))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                listOfWords.Add(line);
                line = reader.ReadLine();
            }
        }

        return listOfWords;
    }
}

