using System;

//•	Using loops write a program that converts an integer number to its hexadecimal representation.
//•	The input is entered as long. The output should be a variable of type string.
//•	Do not use the built-in .NET functionality.

class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter decimal number:");
        long decimalNumber = long.Parse(Console.ReadLine());
        string[] hexadecimalArray = new string[100];
        int counter = 99;
        while (decimalNumber / 16 > 0 || (decimalNumber / 16 == 0 && decimalNumber % 16 != 0))
        {

            switch (decimalNumber % 16)
            {
                case 0: hexadecimalArray[counter] = "0"; break;
                case 1: hexadecimalArray[counter] = "1"; break;
                case 2: hexadecimalArray[counter] = "2"; break;
                case 3: hexadecimalArray[counter] = "3"; break;
                case 4: hexadecimalArray[counter] = "4"; break;
                case 5: hexadecimalArray[counter] = "5"; break;
                case 6: hexadecimalArray[counter] = "6"; break;
                case 7: hexadecimalArray[counter] = "7"; break;
                case 8: hexadecimalArray[counter] = "8"; break;
                case 9: hexadecimalArray[counter] = "9"; break;
                case 10: hexadecimalArray[counter] = "A"; break;
                case 11: hexadecimalArray[counter] = "B"; break;
                case 12: hexadecimalArray[counter] = "C"; break;
                case 13: hexadecimalArray[counter] = "D"; break;
                case 14: hexadecimalArray[counter] = "E"; break;
                case 15: hexadecimalArray[counter] = "F"; break;
                default:break;
            }
            counter--;
            decimalNumber /= 16;
        }
        for (int i = 0; i < hexadecimalArray.Length; i++)
        {
            Console.Write(hexadecimalArray[i]);
        }
        Console.WriteLine();
    }
}

