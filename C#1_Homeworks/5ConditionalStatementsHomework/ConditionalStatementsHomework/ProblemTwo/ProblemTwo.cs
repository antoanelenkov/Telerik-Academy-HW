using System;

//Write an if-statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.

class BonusScore
{
    static void Main()
    {

        Console.WriteLine(@"Enter value for a number between ""0"" and ""9""");
        int a = int.Parse(Console.ReadLine());
        if (4 > a && a > 0)
        {
            Console.WriteLine(a * 10);
        }
        if (7 > a && a > 3)
        {
            Console.WriteLine(a * 100);
        }
        if (10 > a && a > 7)
        {
            Console.WriteLine(a * 1000);
        }
        if (a < 1 || a > 9)
        {
            Console.WriteLine("invalid score");
        }
    }
}