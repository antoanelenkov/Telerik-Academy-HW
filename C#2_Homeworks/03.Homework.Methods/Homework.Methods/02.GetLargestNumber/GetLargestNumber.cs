using System;

/*
  Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax()
*/

class GetLargestNumber
{

    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number:");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The biggest number is: {0}",GetMax(GetMax(firstNumber,secondNumber),thirdNumber));
    }
}

