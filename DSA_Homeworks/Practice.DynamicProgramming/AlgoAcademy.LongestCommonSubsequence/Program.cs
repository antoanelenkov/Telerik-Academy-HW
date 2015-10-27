using System;

namespace AlgoAcademy.LongestCommonSubsequence
{
    class Program
    {
        static void Main()
        {
            var firstSequenceLength = int.Parse(Console.ReadLine());
            var secondSequenceLength = int.Parse(Console.ReadLine());

            var firstSequence = new int[firstSequenceLength];
            var secondSequence = new int[firstSequenceLength];

            var allFirstNumbers = Console.ReadLine().Split(' ');
            var allSecondNumbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < allFirstNumbers.Length; i++)
            {
                firstSequence[i] = int.Parse(allFirstNumbers[i]);
            }

            for (int i = 0; i < allSecondNumbers.Length; i++)
            {
                secondSequence[i] = int.Parse(allSecondNumbers[i]);
            }

            var nodeMatrix = new int[firstSequenceLength, secondSequenceLength];

            for (int i = 0; i < nodeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nodeMatrix.GetLength(1); j++)
                {
                    if (firstSequence[i] == secondSequence[j])
                    {
                        nodeMatrix[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < nodeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nodeMatrix.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        nodeMatrix[i, j] = nodeMatrix[i, j] + nodeMatrix[i, j - 1];
                        continue;
                    }

                    if (j == 0)
                    {
                        nodeMatrix[i, j] = nodeMatrix[i, j] + nodeMatrix[i-1, j];
                        continue;
                    }

                    nodeMatrix[i, j] = nodeMatrix[i, j] + GetMax(nodeMatrix[i - 1, j], nodeMatrix[i - 1, j - 1], nodeMatrix[i, j - 1]);
                }
            }

            Console.WriteLine(nodeMatrix[firstSequenceLength-1,secondSequenceLength-1]);
        }

        private static int GetMax(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else
            {
                if (b > c)
                {
                    return b;
                }
                else
                {
                    return c;
                }
            }
        }

    }
}
