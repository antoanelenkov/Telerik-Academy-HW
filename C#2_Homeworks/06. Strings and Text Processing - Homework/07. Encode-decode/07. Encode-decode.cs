using System;
using System.Text;

/*•	Write a program that encodes and decodes a string using given encryption key (cipher).
  •	The key consists of a sequence of characters.
  •	The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
 * letter of the string with the first of the key, the second – with the second, etc. When 
 * the last key character is reached, the next is the first.*/

class EncodeDecode
{

    static void Main()
    {
        Console.WriteLine("Enter some text to encode:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a cipher:");
        string cipher=Console.ReadLine();
        string encodedText=EncodeText(text, cipher);
        Console.Write("The encoded text is:");
        Console.WriteLine(encodedText);
        Console.Write("The decoded text is:");
        Console.WriteLine(DecodeText(encodedText, cipher));
    }

    static string  EncodeText(string text, string cipher)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char code = (char)(text[i] + cipher[i%cipher.Length]); 
            sb.Append(code);
        }
        return sb.ToString();
    }

    static string DecodeText(string text, string cipher)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            char code = (char)(text[i] - cipher[i % cipher.Length]);
            sb.Append(code);
        }
        return sb.ToString();
    }

}
