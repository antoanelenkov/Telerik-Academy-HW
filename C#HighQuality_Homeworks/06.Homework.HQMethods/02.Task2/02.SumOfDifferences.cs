namespace Task2
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;

    class SumOfDifferences
    {
        static void Main()
        {
            BigInteger[] inputSequence = ReadInput();

            List<BigInteger> resultSequence = FillResultSequence(inputSequence);

            var result = CalculateResult(resultSequence);

            Console.WriteLine(result);
        }

        private static BigInteger CalculateResult(List<BigInteger> resultSequence)
        {
            BigInteger result = 0;
            for (int i = 0; i < resultSequence.Count; i++)
            {
                if (resultSequence[i] % 2 == 1)
                {
                    result += resultSequence[i];
                }
            }

            return result;
        }

        private static BigInteger[] ReadInput()
        {
            BigInteger[] sequence = Console.ReadLine()
              .Split(' ')
              .Select(BigInteger.Parse)
              .ToArray();

            return sequence;
        }

        private static List<BigInteger> FillResultSequence(BigInteger[] inputSequence)
        {
            var resultSequence = new List<BigInteger>();
            for (int i = 1; i < inputSequence.Length; i++)
            {
                BigInteger absSum = 0;
                var firstNumber = inputSequence[i];
                var secondNumber = inputSequence[i - 1];

                //Math.Abs does not work with BigInteger
                absSum = firstNumber - secondNumber > secondNumber - firstNumber ? firstNumber - secondNumber : secondNumber - firstNumber;

                if (absSum < 0)
                {
                    absSum = -absSum;
                }

                resultSequence.Add(absSum);

                if (absSum % 2 == 0)
                {
                    i++;
                }
            }


            return resultSequence;
        }
    }
}
