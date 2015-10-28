namespace AlgoAcademy.BigIntegerestCommonSubsequence
{
    using System;
    using System.Numerics;
    using System.Linq;


    class Program
    {
        static void Main()
        {
            var firstSequenceLength = int.Parse(Console.ReadLine());
            var secondSequenceLength = int.Parse(Console.ReadLine());

            var firstSequence = new BigInteger[firstSequenceLength];
            var secondSequence = new BigInteger[secondSequenceLength];

            var allFirstNumbers = Console.ReadLine().Split(' ');
            var allSecondNumbers = Console.ReadLine().Split(' ');

            for (int i = 0; i < allFirstNumbers.Length; i++)
            {
                firstSequence[i] = BigInteger.Parse(allFirstNumbers[i]);
            }

            for (int i = 0; i < allSecondNumbers.Length; i++)
            {
                secondSequence[i] = BigInteger.Parse(allSecondNumbers[i]);
            }

            var toProcceed = false;

            var nodeMatrix = new BigInteger[firstSequenceLength, secondSequenceLength];

            for (int i = 0; i < nodeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < nodeMatrix.GetLength(1); j++)
                {
                    if (firstSequence[i] == secondSequence[j] && toProcceed)
                    {
                        nodeMatrix[i, j] = 1;
                        toProcceed = false;
                    }

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
                        nodeMatrix[i, j] = nodeMatrix[i, j] + nodeMatrix[i - 1, j];
                        continue;
                    }

                    nodeMatrix[i, j] = nodeMatrix[i, j] + (new BigInteger[] { nodeMatrix[i - 1, j],nodeMatrix[i, j - 1] }).Max();
                }

                toProcceed = true;
            }

            Console.WriteLine(nodeMatrix[firstSequenceLength - 1, secondSequenceLength - 1]);
        }
    }
}