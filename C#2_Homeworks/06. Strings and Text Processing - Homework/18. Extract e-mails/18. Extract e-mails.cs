using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


//•	Write a program for extracting all email addresses from given text.
//•	All sub-strings that match the format @… should be recognized as emails.

class ExtractEMails
{
    static void Main()
    {
        string text = @"My email is ""zaioBayo@abv.bg"". My friend's email is ""mechoPuh@gmail.com"".";
        Console.WriteLine(text);
        Console.WriteLine("The emails are:");
        Console.WriteLine(String.Join("\n", ExtractEmail(text)));
    }

    static List<string> ExtractEmail(string text)
    {
        var emails = new List<string>();
        string[] email = text.Split(new char[]{ '"' ,' '}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in email)
        {
            if (word.Contains("@"))
            {
                emails.Add(word);
            }
        }
        return emails;
    }
}

