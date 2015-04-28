using System;

/*
 Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
 */

class EnglishDigit
{

    static string ConvertLastDigitInWord(int number)
    {

        int lastDigit = number % 10;
        string word = "";
        switch (lastDigit)
        {
            case 0: word = "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eigth"; break;
            case 9: word = "nine"; break;
        }
        return word;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The last digit in the number is \"{0}\":", ConvertLastDigitInWord(number));
    }
}

