using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareCharArrays
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for length of the first array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for length of the second array:");
        int k = int.Parse(Console.ReadLine());

        char[] arrayOne = new char[n];
        char[] arrayTwo = new char[k];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number \"{0}\" value for the first array:", i);
            arrayOne[i] = char.Parse(Console.ReadLine());


        }
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine("Enter number \"{0}\" value for the second array:", i);
            arrayTwo[i] = char.Parse(Console.ReadLine());
        }
        int iIndex = 0;

        if (n == k)
        {
            for (int i = 0; i < n; i++)
            {

                if (arrayOne[i] == arrayTwo[i])
                {
                    iIndex = i;
                }
                else
                {
                    Console.WriteLine(arrayOne[i] < arrayTwo[i] ? "The first array is earlier int the in lexicographical order." : "The second array is earlier in lexicographical order.");
                    break;
                }
            }
            if (iIndex == n - 1)
            {
                Console.WriteLine("The arrays are at the same position in the lexicographical order.");
            }
        }
        else
        {
            if (n > k)
            {
                Console.WriteLine("The second array is earlier in lexicographical order.");
            }
            else
            {
                Console.WriteLine("The first array is earlier int the in lexicographical order.");
            }
        }


        
    }

}

