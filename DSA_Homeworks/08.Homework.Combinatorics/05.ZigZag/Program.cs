namespace _05.ZigZag
{
    using System;

    class Program
    {
        private static int count = 0;

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            var n = int.Parse(input[0]);
            var k = int.Parse(input[1]);

            var arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            var combArr = new int[k];
            var used = new bool[n];

            VariationsWithNoRepetitions(arr, combArr, used, 0, n, k);
            Console.WriteLine(count);
        }

        private static void VariationsWithNoRepetitions(int[] arr, int[] printArr, bool[] used, int index, int n, int k)
        {
            if (index >= k)
            {
                ValidateCombination(printArr);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    printArr[index] = arr[i];
                    VariationsWithNoRepetitions(arr, printArr, used, index + 1, n, k);
                    used[i] = false;
                }
            }
        }


        private static void ValidateCombination(int[] arr)
        {
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (arr.Length == 1)
                {
                    count++;
                    return;
                }
                if (i == 0)
                {
                    if (!(arr[i] > arr[i + 1]))
                    {
                        return;
                    }

                }
                else if (i == arr.Length - 1)
                {
                    if (!(arr[i] > arr[i - 1]))
                    {
                        return;
                    }
                }
                else
                {
                    if (!(arr[i] > arr[i - 1]) || !(arr[i] > arr[i + 1]))
                    {
                        return;
                    }
                }
            }

            count++;
        }
    }
}
