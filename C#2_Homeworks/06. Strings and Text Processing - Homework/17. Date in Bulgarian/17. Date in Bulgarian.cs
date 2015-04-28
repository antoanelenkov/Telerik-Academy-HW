using System;

/*•	Write a program that reads a date and time given in the format:
 * day.month.year hour:minute:second and prints the date and time 
 * after 6 hours and 30 minutes (in the same format) along with the 
 * day of week in Bulgarian.*/

class DateInBulgarian
{
    static void Main()
    {

        Console.WriteLine("Enter date and time in format  \"day.month.year hour:minute:second\"");
        string inputOne = "25.1.2015 23:35:24";//Console.ReadLine();
        string[] dateArr = inputOne.Split(new char[] { '.', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        var date = new DateTime(Convert.ToInt32(dateArr[2]), Convert.ToInt32(dateArr[1]), Convert.ToInt32(dateArr[0]), 
            Convert.ToInt32(dateArr[3]), Convert.ToInt32(dateArr[4]), Convert.ToInt32(dateArr[5]));
        Console.WriteLine(date);
        Console.Write("The date and time after 6 hours and 30 minutes will be: {0}, ", (date.AddHours(6)).AddMinutes(30));
        switch (date.DayOfWeek.ToString())
        {
            case "Monday":Console.WriteLine("Понеделник");break;
            case "Tuesday": Console.WriteLine("Вторник"); break;
            case "Wednesday": Console.WriteLine("Сряда"); break;
            case "Thursday": Console.WriteLine("Четвъртък"); break;
            case "Friday": Console.WriteLine("Петък"); break;
            case "Saturday": Console.WriteLine("Събота"); break;
            case "Sunday": Console.WriteLine("Неделя"); break;
        }
    }
}
