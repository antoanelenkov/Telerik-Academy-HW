using System;
using System.Collections.Generic;

/*•	Write a method that calculates the number of workdays between today and given date, 
 * passed as parameter.
  •	Consider that workdays are all days from Monday to Friday except a fixed list of public 
 * holidays specified preliminary as array.*/


class Workdays
{
    static void Main()
    {
        Console.WriteLine("Enter the date, before which one you want to know how many working days are remaining:");
        Console.Write("Enter the month:");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the day:");
        int day = int.Parse(Console.ReadLine());
        try
        {
            DateTime date = new DateTime(2015, month, day);
            List<DateTime> noWorkingDays = new List<DateTime>() { new DateTime(2015, 3, 3), new DateTime(2015, 5, 24), new DateTime(2015, 09, 22)};
            Console.WriteLine("The days, in which you should go to work are: {0}", CalculateWorkingDays(date, noWorkingDays));
        }
        catch
        {
            Console.WriteLine("The date format is not valid. Try again!");
        }
    }
    
    static int CalculateWorkingDays(DateTime date, List<DateTime> listOfHolydays)
    {
        int workingdays = (date - DateTime.Today).Days;

        DateTime currentDay = DateTime.Today;
        for (int i = 0; i < (date - DateTime.Today).Days; i++)
        {
            for (int j = 0; j < listOfHolydays.Count; j++)
            {
                if (currentDay == listOfHolydays[j])
                {
                    if (currentDay.ToString("dddd") == "Saturday" || currentDay.ToString("dddd") == "Sunday")
                    {
                    }
                    else
                    {
                        workingdays--;
                    }
                }
            }

            if (currentDay.ToString("dddd") == "Saturday" || currentDay.ToString("dddd") == "Sunday")
            {
                workingdays--;
            }

            currentDay = currentDay.AddDays(1);
        }

        return workingdays;
    }
}

