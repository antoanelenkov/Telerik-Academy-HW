using System;
using System.Globalization;
using System.Text.RegularExpressions;

/*•	Write a program that extracts from a given text all dates that match the 
 * format DD.MM.YYYY.
  •	Display them in the standard date format for Canada.*/

class DatesFromTextInCanada
{
    static void Main()
    {
        string text = "I am born in 20.12.1990.";
        Console.WriteLine("The text is:\n{0}", text);
        Console.WriteLine("In canadian format the date looks like:");
        foreach (Match date in Regex.Matches(text,@"[0-9]{2}.[0-9]{2}.[0-9]{4}"))
        {
            string[] newDate = date.Value.Split('.');
             var dateTwo = new DateTime(Convert.ToInt32(newDate[2]), Convert.ToInt32(newDate[1]), Convert.ToInt32(newDate[0]));
             //The standard date and time format in Canada is ISO 8601, or [YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].
             //Since the Canadian Standards Association adopted the ISO 8601 yyyy-mm-dd (e.g., 2009-12-31) date format, 
             //it has become widely used and it even appears as the default date format in newer releases of Microsoft Windows.
             Console.WriteLine(dateTwo.ToString("yyyy-MM-dd"));
        }
    }
}

