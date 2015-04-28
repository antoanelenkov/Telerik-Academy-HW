using System;

/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” 
(an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
and prints beer time or non-beer time according to the definition above or invalid time 
if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/


    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Enter time of the day in format \"hh:mm tt\"");
            string date=Console.ReadLine();           
            DateTime time=DateTime.Parse(date);                                  
            TimeSpan currentTime = time.TimeOfDay;
            TimeSpan startTime=new TimeSpan(13, 00, 00);
            TimeSpan endTime=new TimeSpan(01, 00, 00);

            if (currentTime > startTime && currentTime < endTime)
            {
                Console.WriteLine("It is beer time");
            }
            else
            {
                Console.WriteLine("It is not beer time");
            }
        }
    }

