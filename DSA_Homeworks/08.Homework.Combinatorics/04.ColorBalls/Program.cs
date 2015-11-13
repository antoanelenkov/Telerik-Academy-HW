namespace _04.ColorBalls
{
    using System;

    class Program
    {
        private static int combinationsCount = 0;

        static void Main(string[] args)
        {
            string input =Console.ReadLine();

            var chars = input.ToCharArray();
            Array.Sort(chars);
            PermuteWithRep(chars, 0, chars.Length);

            Console.WriteLine(combinationsCount);
        }

        static void PermuteWithRep(char[] arr, int start, int n)
        {
            combinationsCount++;

            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                {
                    if (arr[left] != arr[right])
                    {
                        var temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;

                        PermuteWithRep(arr, left + 1, n);
                    }
                }

                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = firstElement;
            }
        }
    }
}
