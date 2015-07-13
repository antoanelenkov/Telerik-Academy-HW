using System.Collections.Generic;
namespace RefactorCSharp2Exam
{
    using System;
    using System.Numerics;

    class Task1
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');
            BigInteger result = ConvertFromDecimalToCat(text, 1, 19);
            string resultText = ConvertFromDecimalToCats(result, 19);
            Console.WriteLine(resultText + " = " + result);
        }


        static BigInteger ConvertFromDecimalToCat(string[] text, int lengthOFCharacter, int numeralSystem)
        {
            BigInteger finalResult = 0;
            for (int i = 0; i < text.Length; i++)
            {
                BigInteger result = 0;
                int cycles = text[i].Length / lengthOFCharacter;
                int digit = 0;

                for (int j = 0; j < cycles; j++)
                {
                    string currentChars = text[i].Substring(0, lengthOFCharacter);

                    switch (currentChars)
                    {
                        case "a": digit = 0; break;
                        case "b": digit = 1; break;
                        case "c": digit = 2; break;
                        case "d": digit = 3; break;
                        case "e": digit = 4; break;
                        case "f": digit = 5; break;
                        case "g": digit = 6; break;
                        case "h": digit = 7; break;
                        case "i": digit = 8; break;
                        case "j": digit = 9; break;
                        case "k": digit = 10; break;
                        case "l": digit = 11; break;
                        case "m": digit = 12; break;
                        case "n": digit = 13; break;
                        case "o": digit = 14; break;
                        case "p": digit = 15; break;
                        case "q": digit = 16; break;
                        case "r": digit = 17; break;
                        case "s": digit = 18; break;
                    }

                    text[i] = text[i].Remove(0, lengthOFCharacter);
                    result = Multiply(result, numeralSystem, digit);
                }
                finalResult += result;
            }
            return finalResult;
        }
        static BigInteger Multiply(BigInteger result, int numeralSystem, int digit)
        {
            result *= numeralSystem;
            result += digit;
            return result;
        }

        static string ConvertFromDecimalToCats(BigInteger number, int NumeralSystem)
        {
            string result = String.Empty;
            if (number == 0)
            {
                return "a";
            }
            while (number > 0)
            {

                BigInteger caseNumber = number % NumeralSystem;
                number /= NumeralSystem;
                switch (caseNumber.ToString())
                {
                    case "0": result = result.Insert(0, "a"); break;
                    case "1": result = result.Insert(0, "b"); break;
                    case "2": result = result.Insert(0, "c"); break;
                    case "3": result = result.Insert(0, "d"); break;
                    case "4": result = result.Insert(0, "e"); break;
                    case "5": result = result.Insert(0, "f"); break;
                    case "6": result = result.Insert(0, "g"); break;
                    case "7": result = result.Insert(0, "h"); break;
                    case "8": result = result.Insert(0, "i"); break;
                    case "9": result = result.Insert(0, "j"); break;
                    case "10": result = result.Insert(0, "k"); break;
                    case "11": result = result.Insert(0, "l"); break;
                    case "12": result = result.Insert(0, "m"); break;
                    case "13": result = result.Insert(0, "n"); break;
                    case "14": result = result.Insert(0, "o"); break;
                    case "15": result = result.Insert(0, "p"); break;
                    case "16": result = result.Insert(0, "q"); break;
                    case "17": result = result.Insert(0, "r"); break;
                    case "18": result = result.Insert(0, "s"); break;
                }
            }
            return result;
        }
    }
}
