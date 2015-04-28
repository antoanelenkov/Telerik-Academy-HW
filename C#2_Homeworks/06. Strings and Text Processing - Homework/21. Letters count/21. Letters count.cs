using System;
using System.Collections.Generic;

//•	Write a program that reads a string from the console and prints all different letters in the 
//  string along with information how many times each letter is found.

class LettersCount
{
    static void Main()
    {
        string text="Write a program that reads a string from the console and prints all different letters in the string.";
        string[] letters = new string[53];        

            for (int j = 0; j < text.Length; j++)
            {
                for (int i = 65; i < 90; i++)
                {
                    if (text[j] == Convert.ToChar(i))
                    {
                        letters[i - 65] += Convert.ToString(text[j]);
                    }  
                }
                for (int i = 97; i < 122; i++)
                {
                    if (text[j] == Convert.ToChar(i))
                    {
                        letters[i - 65] += Convert.ToString(text[j]);
                    }
                }
            }

            var list = new List<string>();
            foreach (var word in letters)
            {
                if (word != null)
                {
                    list.Add(word);
                }
            }
            list.Sort();
            foreach (var word in list)
            {
                Console.WriteLine("{0}-{1} times", word[0], word.Length);
            }

    }
}

