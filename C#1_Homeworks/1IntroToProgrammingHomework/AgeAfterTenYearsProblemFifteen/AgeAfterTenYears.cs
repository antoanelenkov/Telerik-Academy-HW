using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace ConsoleApplication6
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date of your birthday");
            int dayBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter month of your birthday");
            int monthBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year of your birthday");
            int yearBorn = int.Parse(Console.ReadLine());

            
            System.DateTime bornDate = new System.DateTime(yearBorn,monthBorn,dayBorn);//In this line i convert your date of birth in a way, we haven't learnt yet.
            DateTime currentDate = DateTime.Now;// Shows current date.
            TimeSpan differenceInDays = (currentDate - bornDate);//calculates the days, hours, minutes and seconds difference between the two dates.
            int days = (int)differenceInDays.TotalDays;// I need only the days, so I use this method to find them and convert them in int.
            Console.WriteLine("Your Age After Ten Years will be:");
            Console.WriteLine(days/365+10);//Calculates your age in years by dividing with 365 + 10 years to find my your after 10 years
            

        }
    }
}
