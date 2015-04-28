using System;
using System.Collections.Generic;

/*•	A dictionary is stored as a sequence of text lines containing words and 
 * their explanations.
  •	Write a program that enters a word and translates it by using the dictionary.*/

class WordDictionary
{
    static void Main()
    {
        string text = @".NET-platform for applications from Microsoft
CLR-managed execution environment for .NET
namespace-hierarchical organization of classes";
        //Console.WriteLine(dictionary);
        char[] separators = { '\n','-' };
        string[] arrDictionary = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        var dictionaryMap = new Dictionary<string, string>();

        for (int i = 0; i < arrDictionary.Length; i += 2)
        {
            dictionaryMap.Add(arrDictionary[i], arrDictionary[i + 1]);
        }

        Console.WriteLine("Enter word:");
        string word = Console.ReadLine();
        if (dictionaryMap.ContainsKey(word))
        {
            Console.WriteLine(dictionaryMap[word]);
        }
        else
        {
            Console.WriteLine("there is no such word!");
        }
    }
}
