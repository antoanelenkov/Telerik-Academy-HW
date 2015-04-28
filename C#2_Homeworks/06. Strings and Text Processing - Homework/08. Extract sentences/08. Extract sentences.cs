using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//•Write a program that extracts from a given text all sentences containing given word.
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

class ExtractSentences
{

    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine("The text is:\n{0}", text);
        Console.WriteLine("Enter word:");
        string word = Console.ReadLine();
        string wordOne = word.Insert(0, " ").Insert(word.Length + 1, " ");//if the word is in the middle of the sentence.
        string firstLetter = Convert.ToString(word[0]).ToUpper();
        string wordTwo = word//if the word is in the beginning of the sentence.
            .Insert(word.Length, " ")
            .Replace(word[0], char.Parse(firstLetter));
        char[] symbols = { '.' };
        string[] sentences = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("The result is:");
        bool firstSentence = true;
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Insert(sentences[i].Length, " ").IndexOf(wordOne) != -1)
            {
                if (firstSentence)//If it is the first sentence, I delete the "whitespace" before it.
                {
                    Console.Write(sentences[i].Insert(sentences[i].Length, ".").TrimStart());
                    firstSentence = false;
                }
                else
                {
                    Console.Write(sentences[i].Insert(sentences[i].Length, "."));
                }

            }
            if (sentences[i].Insert(sentences[i].Length, " ").IndexOf(wordTwo) != -1)
            {
                if (firstSentence)//If it is the first sentence, I delete the "whitespace" before it.
                {
                    Console.Write(sentences[i].Insert(sentences[i].Length, ".").TrimStart());
                    firstSentence = false;
                }
                else
                {
                    Console.Write(sentences[i].Insert(sentences[i].Length, "."));
                }
            }
        }
        Console.WriteLine();
    }


//This is not my solution!!! It does not work correctly.
//    static void Main(string[] args)
//    {
//        /*
//        We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//        in
//        */

//        //Console.Write("Enter some text: ");
//        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//        in";//Console.ReadLine();
//        Console.Write("Enter a word to search for: ");
//        string key = Console.ReadLine();

//        string[] matches = GetMatches(text, key);
//        if (matches.Length == 0)
//        {
//            Console.WriteLine(Environment.NewLine +
//                "No matches found!");
//        }
//        else
//        {
//            Console.WriteLine(Environment.NewLine +
//                String.Join(" ", matches));
//        }
//    }
//    private static string[] GetMatches(string text, string key)
//    {
//        string[] separateSentences = text
//            .Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

//        List<string> matches = new List<string>();

//        foreach (var sentence in separateSentences)
//        {
//            if (Regex.IsMatch(text, @"\b" + key + @"\b", RegexOptions.IgnoreCase))
//            {
//                matches.Add(sentence.Trim() + '.');
//            }
//        }

//        return matches.ToArray();
//    }


}

