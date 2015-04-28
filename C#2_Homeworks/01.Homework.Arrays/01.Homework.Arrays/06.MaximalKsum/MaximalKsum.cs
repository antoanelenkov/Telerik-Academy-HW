using System;

/*Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.*/



    class MaximalKSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for\"n\":");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for\"k\":");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] maxSumArray = new int[k];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter value element number \"{0}\":",i+1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxNumber = int.MinValue;
            for (int i = 0; i < k; i++)
            {
                //this loop finds the greatest number and gives its value to the new array who has the elements with maximum sum.
                for (int j = 0; j < array.Length ; j++)
                {
                    if (array[j]> maxNumber)
                    {
                        maxNumber = array[j];
                        maxSumArray[i] = array[j];                     
                    }
                }
                //this loop delete the greatest number from the regular array, so next time when i go trough the loop for finding greatest number
                //, I will find the next biggest number after this one.
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == maxNumber)
                    {
                        array[j] = 0;
                    }
                }
                maxNumber = int.MinValue;
            }

            Console.WriteLine("The elements with maximum sum are: " +string.Join(", ",maxSumArray));
        }
    }

