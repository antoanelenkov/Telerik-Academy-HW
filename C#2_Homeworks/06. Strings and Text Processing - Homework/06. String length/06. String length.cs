using System;
using System.Text;

/*•	Write a program that reads from the console a string of maximum 20 characters. If the 
 * length of the string is less than 20, the rest of the characters should be filled with *.
  •	Print the result string into the console.*/

class StringLength
{
    static void Main()
    {
        Console.WriteLine("Enter text not more than 20 symbols:");
        string text=Console.ReadLine();
        if (text.Length > 20)
        {
            Console.WriteLine("Tooooooo long text. Sorry :)");
            return;
        }
        StringBuilder sb = new StringBuilder();
        sb.Append(text);
        sb.Append('*', 20 - text.Length);
        Console.WriteLine(sb.ToString());       
    }
}
