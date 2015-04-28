using System;

//• Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

class SubStringInText
{
    static void Main()
    {
        string text = @"The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
            So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        string substring = "in";
        int counter = 0;
        int index = text.IndexOf(substring);

        while (index != -1)
        {
            counter++;
            index = text.IndexOf(substring, index + 1);
        }
        Console.WriteLine("The sub-string \"{0}\" is {1} times met in the sentence.", substring,counter);
    }
}

