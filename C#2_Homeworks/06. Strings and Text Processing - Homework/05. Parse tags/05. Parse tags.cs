using System;

//	You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and</upcase> to upper-case.
//	The tags cannot be nested.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("The example text is:\n{0}", text);
        string separatorOne = "<upcase>";
        string separatorTwo = "</upcase>";
        int indexOne = text.IndexOf(separatorOne);
        int indexTwo = text.IndexOf(separatorTwo);

        do
        {
            int startIndex = indexOne + separatorOne.Length;
            int length = indexTwo - (indexOne + separatorOne.Length);
            string textToBeChanged = text.Substring(startIndex, length);
            text = text.Replace(textToBeChanged, textToBeChanged.ToUpper());
            indexOne = text.IndexOf(separatorOne, indexOne + 1);
            indexTwo = text.IndexOf(separatorTwo, indexTwo + 1);
        }
        while (indexOne != -1);

        text = text.Replace(separatorOne, "");
        text = text.Replace(separatorTwo, "");
        Console.WriteLine("The result text is:\n{0}", text);
    }
}

