using System;
using System.Text;

//•	Write a program that reads a string, reverses it and prints the result at the console.

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        Console.WriteLine("Thre reversed text is:");
        StringBuilder reversedText = new StringBuilder(text.Length);

        for (int i = text.Length-1; i >= 0; i--)
        {
            reversedText.Append(text[i]);
        }
        Console.WriteLine(reversedText.ToString());
    }
}
