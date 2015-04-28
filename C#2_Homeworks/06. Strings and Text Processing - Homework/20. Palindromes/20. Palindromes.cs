using System;
using System.Text;

//•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

class Palindromes
{
    static void Main()
    {      
        string text = " Some words: exe, rar, ABBA, zaio, bayo, petio, gosho, hahah, xixix.";
        Console.WriteLine("The text is: {0}",text);
        string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("The palindromes are:");
        foreach (var word in words)
        {
            StringBuilder sb=new StringBuilder();
            for (int i = word.Length-1; i >= 0; i--)
			{
			    sb.Append(word[i]);
			}

            if (word == sb.ToString())
            {
                Console.WriteLine(word);
            }
        }
    }
}
