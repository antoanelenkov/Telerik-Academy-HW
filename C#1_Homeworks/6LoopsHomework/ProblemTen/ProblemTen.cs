using System;

//•	You are given n integers (given in a single line, separated by a space).
//•	Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//•	Elements are counted from 1 to n, so the first element is odd, the second is even, etc.


namespace ProblemTen
{
    class  OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values  of the sequence by separeting them  with \"space\" and when you are ready, click \"enter\"");
            string[] elements = Console.ReadLine().Split(' ');
            int[] array = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                array[i] = int.Parse(elements[i]);
                Console.Write(" ");
            }
            int productOfOdd = 1;

            for (int i = 0; i < elements.Length; i += 2)
            {
                productOfOdd *= array[i];
            }
            int productOfEven = 1;

            for (int i = 1; i < elements.Length; i += 2)
            {
                productOfEven *= array[i];
            }

            if (productOfOdd == productOfEven)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
