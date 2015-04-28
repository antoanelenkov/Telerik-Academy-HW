using System;

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.


class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");

        int[] array = new int[5];//Define an array.It is a lot easier, we will learn it in next course(C#2)

        for (int i = 0; i < 5; i++)//Array for inserting values for all of the variables.
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 4; i++)//Array for the algorithm.
        {
            for (int j = i+1; j < 5; j++)
            {
                if (array[i] + array[j]==0)
                {
                    Console.WriteLine("("+ array[i] +")+("+ array[j]+")=0");
                }
            }
        }
    }
}
