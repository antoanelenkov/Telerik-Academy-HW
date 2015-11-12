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
            //CombinateWithRepetitions(0,0);

            //03. Modify the previous program to SKIP DUPLICATES:
            //n = 4, k = 2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
            //CombinationsWithoutRepetitions(0, 0);

            //BONUS. Combinate WITH DUPLICATES array of words
            //CombinateWordsWithRepetitions(words, 0, 0);

            //06.Write a program for generating and printing all subsets of k strings from given set of strings.
            //Example: s = { test, rock, fun}, k = 2 → (test rock), (test fun), (rock fun)
            //CombinateWordsWithoutRepetitions(subset, 0, 0);

            //-------------------PERMUTATIONS-------------------------

            //04. Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., 
            //n for given integer number n. Example:
            //n = 3 → { 1, 2, 3}, { 1, 3, 2}, { 2, 1, 3}, { 2, 3, 1}, { 3, 1, 2},{ 3, 2, 1}
            //Permutate(permutations, 0);

            //11. *Write a program to generate all permutations with repetitionsof given multi-set.
            //Example: the multi-set { 1, 3, 5, 5} has the following 12 unique permutations.
            //Array.Sort(permutationsRep);
            //PermuteWithRep(permutationsRep,0, permutationsRep.Length);

            //-------------------VARIATIONS-------------------------

            //05. Write a recursive program for generating and printing all ordered k-element subsets from n-element set (VARIATIONS WITH REPETITIONS Vkn).
            //Example: n = 3, k = 2, set = { hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
            //VariationsWithRepetitions(variationsWithReps,0);

            //05.1. VARIATIONS WITHOUT repetitions
            //Example: n = 3, k = 2, set = { hi, a, b} →  (hi a), (hi b), (a hi), (a b), (b hi), (b a)
            VariationsWithNoRepetitions(variationsWithReps,0);
        }
        //06 combinations without repetitions k elements from n-element set
        private static string[] subset = { "test", "rock", "fun" };
        private static int k6 = 2;
        private static int n6 = subset.Length;
        private static string[] subsetBuffer = new string[k6];


        private static void CombinateWordsWithoutRepetitions(string[] arr, int index,int start)
        {
            if (index >= k6)
            {
                PrintArray(subsetBuffer);
                return;
            }

            for (int i = start; i < n6; i++)
            {
                subsetBuffer[index] = arr[i];
                CombinateWordsWithoutRepetitions(arr, index + 1,i+1);
            }
        }

        //05 ---------------Variations with repetitions k=2 from n=3  
        private static string[] variationsWithReps = new string[] { "hi", "a", "b" };
        private static int k5 = 3;
        private static string[] variationsBuffer = new string[k5];
        private static int n5 = variationsWithReps.Length;

        private static void VariationsWithRepetitions<T>(T[] arr, int index)
        {
            if (index >= k5)
            {
                PrintArray(variationsBuffer);
                return;
            }

            for (int i = 0; i < n5; i++)
            {
                variationsBuffer[index] = arr[i].ToString();
                VariationsWithRepetitions(arr, index + 1);
            }
        }

        //05.1 ---------------Variations withOUT repetitions k=2 from n=3  
        private static string[] variationsWithNoReps = new string[] { "hi", "a", "b" };
        private static int kb2 = 2;
        private static string[] variationsNoRepBuffer = new string[kb2];
        private static int nb2 = variationsWithNoReps.Length;
        private static bool[] used = new bool[nb2];

        private static void VariationsWithNoRepetitions<T>(T[] arr, int index)
        {
            if (index >= kb2)
            {
                PrintArray(variationsBuffer);
                return;
            }

            for (int i = 0; i < nb2; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variationsBuffer[index] = arr[i].ToString();
                    VariationsWithNoRepetitions(arr, index + 1);
                    used[i] = false;
                }
            }
        }

        //04----------------Permutations with no repetitons
        private static int[] permutations = new int[] { 1, 2, 3 };

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
        private static int[] permutationsRep = new int[] {1,1,1,12,1,5};

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

        private static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
        }

        //bonus---------------words array k elements from n-element set 
        private static string[] words = { "first", "second", "third" };
        private static string[] wordsBuffer = new string[words.Length];
        private static int nBonus = words.Length;
        private static int kBonus = 3;

        private static void CombinateWordsWithRepetitions(string[] arr, int index, int start)
        {
            if (index >= kBonus)
            {
                PrintArray(wordsBuffer);
                return;
            }

            for (int i = start; i < nBonus; i++)
            {
                wordsBuffer[index] = arr[i];
                CombinateWordsWithRepetitions(arr, index + 1, i);
            }
        }

        //02--------------combinations with repetitions  k elements from n-element set
        private static int n2 = 3;
        private static int k2 = 3;
        private static int[] numbers2 = new int[k2];
        private static void CombinateWithRepetitions(int index, int start)
        {
            if (index >= k2)
            {
                PrintArray(numbers2);
                return;
            }

            for (int i = start; i < n2 + 1; i++)
            {
                numbers2[index] = i;
                CombinateWithRepetitions(index + 1, i);
            }
        }

        //03--------------combinations without repetitions k elements from n-element set
        private static int n3 = 3;
        private static int k3 = 3;
        private static int[] numbers3 = new int[k3];
        private static int[] numbers3Buffer = new int[numbers3.Length];
        private static void CombinationsWithoutRepetitions<T>(T[] arr, int index, int start)
        {
            if (index >= k3)
            {
                PrintArray(arr);
                return;
            }

            for (int i = start; i < n3 + 1; i++)
            {
                numbers3Buffer[index] = int.Parse(arr[i].ToString());
                CombinationsWithoutRepetitions(arr, index + 1, i + 1);
            }
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

        private static void PrintArray<T>(T[] arr)
        {
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
