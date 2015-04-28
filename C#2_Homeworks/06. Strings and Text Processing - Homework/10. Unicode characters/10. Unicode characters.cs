using System;
using System.Text;

//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        Console.WriteLine("This text in unicode format looks like:");
        foreach (char symbol in text)
        {
            Console.Write(ConvertInUnicode(symbol));
        }
        Console.WriteLine();
    }

    static string ConvertInUnicode(char symbol)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("\\u");
        sb.Append(String.Format("{0:X4}", (int)symbol));
        return sb.ToString();
    }
}

