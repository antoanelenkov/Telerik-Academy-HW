using System;

//•	Write a program that replaces in a HTML document given as string all the tags
//  <a href="…">…</a> with corresponding tags [URL=…]…/URL].

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Example:");
        string text=@"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(text);
        Console.WriteLine("Converted text:");
        Console.WriteLine( text.Replace("<a href=\"", "[URL=").Replace("\">", "]").Replace("</a>", "[/URL]") ); 
    }
}

