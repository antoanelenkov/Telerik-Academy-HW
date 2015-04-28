using System;

/*
•	Using loops write a program that converts a hexadecimal integer number to its decimal form.
•	The input is entered as string. The output should be a variable of type long.
•	Do not use the built-in .NET functionality.
*/


class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter hexadecimal number with capital letters:");
        string hexadecimalNumber = Console.ReadLine();
        char[] arrayWithSymbols = hexadecimalNumber.ToCharArray(0, hexadecimalNumber.Length);
        double sum = 0;
        int degree = 0;
        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            switch (arrayWithSymbols[i])
            {
                case '1': sum += 1 * Math.Pow(16, degree); break;
                case '2': sum += 2 * Math.Pow(16, degree); break;
                case '3': sum += 3 * Math.Pow(16, degree); break;
                case '4': sum += 4 * Math.Pow(16, degree); break;
                case '5': sum += 5 * Math.Pow(16, degree); break;
                case '6': sum += 6 * Math.Pow(16, degree); break;
                case '7': sum += 7 * Math.Pow(16, degree); break;
                case '8': sum += 8 * Math.Pow(16, degree); break;
                case '9': sum += 9 * Math.Pow(16, degree); break;
                case 'A': sum += 10 * Math.Pow(16, degree); break;
                case 'B': sum += 11 * Math.Pow(16, degree); break;
                case 'C': sum += 12 * Math.Pow(16, degree); break;
                case 'D': sum += 13 * Math.Pow(16, degree); break;
                case 'E': sum += 14 * Math.Pow(16, degree); break;
                case 'F': sum += 15 * Math.Pow(16, degree); break;
            }
            degree++;

        }
        Console.WriteLine(sum);




    }
}

