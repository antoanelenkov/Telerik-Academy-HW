using System;

//•	Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class RandomizeTheNumbersFromOneToN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] randomNumbersArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            int randomNumber=rnd.Next(1,n+1);//every time when the program go in the loop, it returns different random number.
            randomNumbersArray[i] = randomNumber;
            //This method "Next(x,y)" returns random numbers including the lower bound(x) and excluding the upper bound(y),that's why the  upper bound is "n+1".
            for (int j = 0; j < i; j++)
            {
                if (randomNumbersArray[i] == randomNumbersArray[j])
                {
                    i--;
                    //if the "if" condition is "true", the current array member need to be changed, so I start the loop again and try to find another random number for that member.
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(randomNumbersArray[i] + " ");
        }
        Console.WriteLine();
    }
}

/*Console.WriteLine("Enter value for n:");
int n = int.Parse(Console.ReadLine());
Random rnd=new Random();
int[] array = new int[n];
int counter = 1;
int randomNumberr = rnd.Next(1, n);
array[0] = randomNumberr;
Console.Write(array[0]+" ");
       
while(counter<n-1)
{
    int randomNumber = rnd.Next(1,n);
    for (int i = 0; i < counter; i++)
    {
        if (randomNumber != array[i])
        {
            array[counter] = randomNumber;
            Console.Write(array[counter] + " ");
            counter++;
        }
    }
               
                    
}
Console.WriteLine();*/