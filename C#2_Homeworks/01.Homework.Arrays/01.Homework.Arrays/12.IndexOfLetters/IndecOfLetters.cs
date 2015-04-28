using System;
/*Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array*/



class Program
{
    static void Main(string[] args)
    {
        int[] intArray = new int[26];
        char[] charArray = new char[26];

        for (int i = 0; i < charArray.Length; i++)
        {
            intArray[i] = i + 97;//Represents the  index of the first letter in the ASCII table.
            charArray[i] = Convert.ToChar(intArray[i]);
        }

        Console.WriteLine("Enter a word in lowercase(Use only letters from the english alphabet):");
        string word = Console.ReadLine();
        foreach (char symbol in word)
        {
            Console.WriteLine("The index of the letter \"{0}\" is:\"{1}\".",symbol,Convert.ToInt16(symbol)-96);
        }
    }
}

