using System;

//•	Write a program that reads from the console a sequence of n integer numbers 
//and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//•	The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//•	The output is like in the examples below.




class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for lenght of the sequence:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter value for element \"{0}\":", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            if (array[i] > maxNumber)
            {
                maxNumber = array[i];
            }
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
            sum += array[i];
        }

        double average = (double)sum / n;
        Console.WriteLine("max=" + maxNumber);
        Console.WriteLine("min=" + minNumber);
        Console.WriteLine("sum=" + sum);
        Console.WriteLine("average={0:F2}",average);
    }
}
