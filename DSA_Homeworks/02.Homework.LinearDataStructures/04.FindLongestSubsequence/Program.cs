using System.Collections.Generic;

namespace _04.FindLongestSubsequence
{
    class Program
    {
        static void Main()
        {
            /*Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
            Write a program to test whether the method works correctly.*/

            var numbers = new List<int>() { 1, 1, 1, 2, 3, 4, 4, 4, 4, 4, 6, 6, 6, 6, 6, 6, 7, 7 };

            var resultNumber = numbers[0];
            var currentNumber = numbers[0];
            var mostOccurances = 0;
            var currentOccurances = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == currentNumber)
                {
                    currentOccurances += 1;
                }
                else
                {
                    if (currentOccurances > mostOccurances)
                    {
                        mostOccurances = currentOccurances;
                        resultNumber = currentNumber;

                        currentOccurances = 1;
                    }
                }

                currentNumber = numbers[i];
            }

            System.Console.WriteLine("most occurances are: {0} with number: {1}", mostOccurances, resultNumber);
        }
    }
}
