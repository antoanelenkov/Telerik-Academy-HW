using System;
/*•	Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
 * percentage and in scientific notation.
  •	Format the output aligned right in 15 symbols.*/


class FormatNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = 15;//int.Parse(Console.ReadLine());
        Console.WriteLine("As decimal: \n{0,15:D}", number);
        Console.WriteLine("As hexadecimal: \n{0,15:X}", number);
        Console.WriteLine("As percentage: \n{0,15:P0}", number);
        Console.WriteLine("With scientific notation:\n {0,14:E2}", number);
    }
}

