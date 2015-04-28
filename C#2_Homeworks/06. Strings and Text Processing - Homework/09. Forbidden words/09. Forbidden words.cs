using System;
using System.Text;

/* •	We are given a string containing a list of forbidden words and a text containing some of 
 * these words.
   •	Write a program that replaces the forbidden words with asterisks.*/

class ForbiddenWords
{
   static void Main()
    {
        string forbiddenWords = " PHP, CLR, Microsoft";
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine("Text before replacing:");
        Console.WriteLine(text);
       char[] separators = { ',', ' ' };
        string[] forbiddenWordsArr = forbiddenWords.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < forbiddenWordsArr.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('*', forbiddenWordsArr[i].Length);
            text = text.Replace(forbiddenWordsArr[i], sb.ToString());
        }
        Console.WriteLine("Text after replacing:");
        Console.WriteLine(text);
    }
}

