using System;
using System.Collections.Generic;
using System.Text;

/*
 * Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */


class SolveTasks
{

    static void Main(string[] args)
    {
        ConsoleKeyInfo button;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.For converting a non-negativ decimal number, press\"1\"!");
            Console.WriteLine("2.For calculating the average of a sequence of integers, press\"2\"!");
            Console.WriteLine("3.For solving a linear equation, press\"3\"!");
            button = Console.ReadKey();
            if (button.Key == ConsoleKey.D1)
            {
                
                Console.WriteLine();
                Console.WriteLine("Enter a decimal number:");
                long number = long.Parse(Console.ReadLine());
                while(number < 0)
                {
                    Console.WriteLine("Please enter possitive value:");
                    number = long.Parse(Console.ReadLine());
                }
                Console.WriteLine("The reverse number is: {0}", ConvertToReverseNumber(number));
            }

            if (button.Key == ConsoleKey.D2)
            {
                List<int> array = new List<int>();
                Console.WriteLine();
                Console.WriteLine("Enter values for the numbers of the sequence. Separate them with \"space\". When you are ready, press\"esc\".");
                while (true)
                {
                    Console.WriteLine("Enter number:");
                    array.Add(int.Parse(Console.ReadLine()));
                    Console.WriteLine("If you want to keep filling the sequence, press \"enter\", else press any key to continue...");
                    button = Console.ReadKey();
                    if (button.Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("The average number is: {0:F2}", FindTheAverage(array));
            }
            if (button.Key == ConsoleKey.D3)
            {
                Console.WriteLine();
                Console.WriteLine("Enter coeficient a:");
                int a = int.Parse(Console.ReadLine());
                while(a == 0)
                {
                    Console.WriteLine("Please  enter value different from \"0\":");
                    a = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter coeficient b:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The root is:{0}", SolvesLinearEquation(a, b));
            }

            Console.WriteLine("If you are ready, press \"esc\", else press any button for continue with opearations!");
            button = Console.ReadKey();
        }
        while (button.Key != ConsoleKey.Escape);


    }

    static string ConvertToReverseNumber(long number)
    {
        while (number % 10 == 0)
        {
            number /= 10;
        }
        int numberLength = Convert.ToString(number).Length;
        StringBuilder reverseNumber = new StringBuilder();
        for (int i = 0; i < numberLength; i++)
        {
            reverseNumber.Append(Convert.ToString(number % 10));
            number = number / 10;
        }
        return reverseNumber.ToString();
    }

    static double FindTheAverage(List<int> list)
    {
        int sum = 0;
        double averageNumber;

        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        averageNumber = (double)sum / list.Count;

        return averageNumber;
    }

    static double SolvesLinearEquation(int a, int b)
    {
        double root = -(double)b / a;
        return root;
    }
}

