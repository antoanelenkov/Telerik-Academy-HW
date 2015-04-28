using System;

//•	Write a program that enters 3 integers n, min and max (min = max) 
//and prints n random numbers in the range[min...max].

namespace ProblemEleven
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for the range of random numbers:");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for the minimum number:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for the maximum number:");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < range; i++)
            {
                //This method "Next(x,y)" returns random numbers including the lower bound(x) and excluding the upper bound(y),that's why the  upper bound is "max+1"
                int randomNumber = rnd.Next(min, max + 1);
                Console.Write(randomNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
