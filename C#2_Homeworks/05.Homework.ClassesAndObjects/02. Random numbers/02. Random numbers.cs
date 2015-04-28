using System;

class RandomNumbers
{
    static void Main()
    {
        //•	Write a program that generates and prints to the console 10 random values in the range [100, 200].
        Random randomGenerator = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Random number [{0}]: {1}",i+1,randomGenerator.Next(100, 201));
        }
    }
}

