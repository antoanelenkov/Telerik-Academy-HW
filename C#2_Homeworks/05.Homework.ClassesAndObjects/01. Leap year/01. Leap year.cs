using System;

//•	Write a program that reads a year from the console and checks whether it is a leap one.
//•	Use System.DateTime.

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter an year to check if it is leap or not:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(DateTime.IsLeapYear(year) ? "This year is Leap" : "The year is not Leap");

        //Second way of solving the problem. Just practicing catching exceptions :)
        /*Console.WriteLine("Enter an year to check if it is leap or not:");
        int year = int.Parse(Console.ReadLine());
        try
        {
            DateTime date = new DateTime(year, 2, 29);
            Console.WriteLine("The year is leap!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The year is not leap!");
        }*/
    }
}




