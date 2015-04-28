using System;
using System.Collections.Generic;

//•	Write a program that reads a string from the console and lists all different words in the 
//  string along with information how many times each word is found.

class WordsCount
{
    static void Main()
    {
        string text = /*Console.ReadLine()*/"Write a program program that reads a string from the console and prints all different letters in the string.Zaio Bayo, Zaio Bayo, Zaio Bayo";
        var dictionary = new Dictionary<string, int>();
        string[] letters = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(letters);
        for (int i = 0; i < letters.Length; i++)
        {
            int counter = 0;
            foreach (var word in letters)
            {
                if (word == letters[i])
                {
                    counter++;
                }
            }
            if (!dictionary.ContainsKey(letters[i]))
            {
                dictionary.Add(letters[i], counter);
            }
        }

        foreach (var pair in dictionary)
        {
            Console.WriteLine("{0} - {1}",
            pair.Key.ToString().PadRight(10),
            pair.Value);
        }
    }
}

