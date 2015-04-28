using System;

//•	Write a program to check if in a given expression the brackets are put correctly.

class CorrectBrackets
{
    static void Main()
    {
        string rightExpression = "(5+6)*(7*(8-9))";
        string wrongExpression = "(5+6)(7*(8-9))";

        int index= rightExpression.IndexOf(")(");
        if (index == -1)
        {
            Console.WriteLine("The brackets of {0} are put correctly!", rightExpression);
        }
        else
        {
            Console.WriteLine("The brackets of {0} are not put correctly!", rightExpression);
        }

        if (index != -1)
        {
            Console.WriteLine("The brackets of {0} are put correctly!", wrongExpression);
        }
        else
        {
            Console.WriteLine("The brackets of {0} are not put correctly!", wrongExpression);
        }
    }
}

