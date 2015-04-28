using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//•	Write a program that reverses the words in given sentence.

class ReverseSentence
{
    static void Main()
    {
        string text = "C# is not C++, not SQL, not PHP. It is not easy as well, because I needed 2 hours to solve the problem!";
        Console.WriteLine(text);
        string lastSymbol = Convert.ToString(text[text.Length - 1]);
        char[] separators = { ' ', ',', '!', '.' };
        string[] splitedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(splitedText);

        int notationCounter = 1;
        var notationDictionary = new Dictionary<int, string>();
        //Fills list with notations.
        foreach (var symbol in text)
        {
            if (symbol == ' ')
            {
                notationCounter++;
            }
            if (symbol == ','||symbol=='.'||symbol=='!')
            {
                notationDictionary.Add(notationCounter, Convert.ToString(symbol));
                notationCounter++;
            }
        }

        var newSentence = new List<string>();
        int counter = 0;
        //Fills the List with words and symbols
        for (int i = 0; i < splitedText.Length + notationDictionary.Count; i++)
        {
            if (notationDictionary.ContainsKey(i))
            {
                newSentence.Add(notationDictionary[i]);
            }
            else
            {
                newSentence.Add(splitedText[counter]);
                counter++;
            }
        }
        //Prints the result
        for (int i = 0; i < newSentence.Count; i++)
        {
            if (i == newSentence.Count - 1)//condition for the last symbol
            {
                Console.Write(newSentence[i]);
                break;
            }
            if (i != newSentence.Count - 1 && newSentence[i + 1] == "," || newSentence[i + 1] == "." || newSentence[i + 1] == "!")//condition for the whitespaces around "comas"
            {
                Console.Write(newSentence[i]);
            }
            else
            {
                Console.Write(newSentence[i] + " ");
            }
        }
        Console.WriteLine();
    }
}

