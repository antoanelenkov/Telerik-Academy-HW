using System;
using System.Text;

// of consecutive identical letters with a single one.
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:
//input	output
//aaaaabbbbbcdddeeeedssaa

class SeriesOfLetters
{
    static void Main()
    {
        string text =/*Console.ReadLine();*/"aaaaabbbbbcdddeeeedssa";
        Console.WriteLine("Text is:\n{0}",text);
        StringBuilder sb = new StringBuilder();
        sb.Append(text[0]);
        for (int i = 0; i < text.Length; i++)
        {
           if (text[i] != sb[sb.Length-1])
            {
                sb.Append(text[i]);       
            }
        }
        Console.WriteLine("Result is:\n{0}",sb.ToString());
    }
}

