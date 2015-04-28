using System;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

class DateDifference
{
    static void Main()
    {
        Console.WriteLine("Enter first date in format \"date.month.year\"");
        string inputOne = "25.1.2015";//Console.ReadLine();
        string[] dateArr = inputOne.Split('.');
        var dateOne = new DateTime(Convert.ToInt32(dateArr[2]), Convert.ToInt32(dateArr[1]), Convert.ToInt32(dateArr[0]));
        Console.WriteLine(dateOne);
        Console.WriteLine("Enter second date in format \"date.month.year\"");
        string inputTwo = "25.3.2015";//Console.ReadLine();
        string[] dateArrr = inputTwo.Split('.');
        var dateTwo = new DateTime(Convert.ToInt32(dateArrr[2]), Convert.ToInt32(dateArrr[1]), Convert.ToInt32(dateArrr[0]));
        Console.WriteLine(dateTwo);
        Console.WriteLine("The distance between these two days are {0} day/days",  (dateTwo-dateOne).Days);
    }
}

