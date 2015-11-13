namespace _01_06.Combinatorics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        private static void Main()
        {
            //01. Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
            //SimulateLoops(0);

            //-------------------COMBINATIONS-------------------------

            //02. Write a recursive program for generating and printing 
            //all the COMBINATIONS WITH DUPLICATES of k elements from n-element set. Example:
            //n = 3, k = 2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
            int k2 = 3;
            int[] numbers2 = new int[] { 1, 2, 3 };
            int[] numbers2Buffer = new int[k2];
            //CombinateWithRepetitions(numbers2, numbers2Buffer, 0, 0,numbers2.Length, numbers2Buffer.Length);

            //03. Modify the previous program to SKIP DUPLICATES:
            //n = 4, k = 2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
            int k3 = 2;
            int[] numbers3 = new int[] { 1, 2, 3, 4 };
            int[] numbers3Buffer = new int[k3];
            //CombinationsWithoutRepetitions(numbers3, numbers3Buffer, 0, 0, numbers3Buffer.Length, numbers3.Length);

            //06.Write a program for generating and printing all subsets of k strings from given set of strings.
            //Example: s = { test, rock, fun}, k = 2 → (test rock), (test fun), (rock fun)
            string[] subset = { "test", "rock", "fun" };
            int k6 = 2;
            int n6 = subset.Length;
            string[] subsetBuffer = new string[k6];
            //CombinationsWithoutRepetitions(subset, subsetBuffer, 0, 0, k6, n6);

            //-------------------PERMUTATIONS-------------------------

            //04. Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., 
            //n for given integer number n. Example:
            //n = 3 → { 1, 2, 3}, { 1, 3, 2}, { 2, 1, 3}, { 2, 3, 1}, { 3, 1, 2},{ 3, 2, 1}
            int[] permutations = new int[] { 1, 2, 3 };
            //Permutate(permutations, 0);

            //11. *Write a program to generate all permutations with repetitionsof given multi-set.
            //Example: the multi-set { 1, 3, 5, 5} has the following 12 unique permutations.
            int[] permutationsRep = new int[] { 1, 1, 1, 12, 1, 5 };
            Array.Sort(permutationsRep);
            //PermuteWithRep(permutationsRep, 0, permutationsRep.Length);

            //-------------------VARIATIONS-------------------------

            //05. Write a recursive program for generating and printing all ordered k-element subsets from n-element set (VARIATIONS WITH REPETITIONS Vkn).
            //Example: n = 3, k = 2, set = { hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
            string[] variationsWithReps = new string[] { "hi", "a", "b" };
            int k5 = 3;
            string[] variationsBuffer = new string[k5];
            //VariationsWithRepetitions(variationsWithReps, variationsBuffer, 0, variationsWithReps.Length, variationsBuffer.Length);

            //05.1. VARIATIONS WITHOUT repetitions
            //Example: n = 3, k = 2, set = { hi, a, b} →  (hi a), (hi b), (a hi), (a b), (b hi), (b a)
            string[] variationsWithNoReps = new string[] { "hi", "a", "b" };
            int kb2 = 2;
            string[] variationsNoRepBuffer = new string[kb2];
            int nb2 = variationsWithNoReps.Length;
            bool[] used = new bool[nb2];
            //VariationsWithNoRepetitions(variationsWithReps, variationsNoRepBuffer,used, 0 , variationsWithNoReps.Length, variationsNoRepBuffer.Length);
        }

        //01
        private static int numberOfLoops = 4;
        private static int[] numbers = new int[numberOfLoops];

        private static void SimulateLoops(int index)
        {
            if (index >= numberOfLoops)
            {
                PrintArray(numbers);
                return;
            }

            for (int i = 1; i < numberOfLoops; i++)
            {
                numbers[index] = i;
                SimulateLoops(index + 1);
            }
        }

        //02--------------combinations with repetitions  k elements from n-element set
        private static void CombinateWithRepetitions<T>(T[] arr, T[] printArr, int index, int start, int n, int k)
        {
            if (index >= k)
            {
                PrintArray(printArr);
                return;
            }

            for (int i = start; i < n; i++)
            {
                printArr[index] = arr[i];
                CombinateWithRepetitions(arr, printArr, index + 1, i, n, k);
            }
        }

        //03--------------combinations without repetitions k elements from n-element set
        private static void CombinationsWithoutRepetitions<T>(T[] arr, T[] printArr, int index, int start, int k, int n)
        {
            if (index >= k)
            {
                PrintArray(printArr);
                return;
            }

            for (int i = start; i < n; i++)
            {
                printArr[index] = arr[i];
                CombinationsWithoutRepetitions(arr, printArr, index + 1, i + 1, k, n);
            }
        }

        //04----------------Permutations with no repetitons
        private static void Permutate<T>(T[] permutations, int index)
        {
            if (index >= permutations.Length)
            {
                PrintArray(permutations);
                return;
            }

            Permutate(permutations, index + 1);
            for (int i = index + 1; i < permutations.Length; i++)
            {
                Swap(ref permutations[index], ref permutations[i]);
                Permutate(permutations, index + 1);
                Swap(ref permutations[index], ref permutations[i]);
            }
        }

        //11----------------Permutations with repetitons
        static void PermuteWithRep(int[] arr, int start, int n)
        {
            PrintArray(arr);

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteWithRep(arr, left + 1, n);
                    }
                }

                // Undo all modifications done by the
                // previous recursive calls and swaps
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = firstElement;
            }
        }

        //05 ---------------Variations with repetitions k=2 from n=3  
        private static void VariationsWithRepetitions<T>(T[] arr, T[] printArr, int index, int n, int k)
        {
            if (index >= k)
            {
                PrintArray(printArr);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                printArr[index] = arr[i];
                VariationsWithRepetitions(arr, printArr, index + 1, n, k);
            }
        }

        //05.1 ---------------Variations withOUT repetitions k=2 from n=3  

        private static void VariationsWithNoRepetitions<T>(T[] arr, T[] printArr,bool[] used, int index, int n, int k)
        {
            if (index >= k)
            {
                PrintArray(printArr);
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    printArr[index] = arr[i];
                    VariationsWithNoRepetitions(arr, printArr,used, index + 1, n, k);
                    used[i] = false;
                }
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        private static void PrintArray<T>(T[] arr)
        {
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
