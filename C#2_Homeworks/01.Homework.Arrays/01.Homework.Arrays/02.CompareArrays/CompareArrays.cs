using System;
//Write a program that reads two integer arrays from the console and compares them element by element.



class CompareArrays
{
    static void Main(string[] args)
    {
        int[] arrayOne = new int[5];
        int[] arrayTwo = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number \"{0}\" value for the first array:",i);
            arrayOne[i] = int.Parse(Console.ReadLine());


        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number \"{0}\" value for the second array:", i);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(arrayOne[i] > arrayTwo[i] ? "Position \"{0}\" value of  the first array is greater" : "Position \"{0}\" value of the second array is greater",i+1);
        }
    }
}

