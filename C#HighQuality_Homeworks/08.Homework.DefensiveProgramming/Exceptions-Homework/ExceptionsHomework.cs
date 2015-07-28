using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr must not be null");
        }

        if (startIndex < 0)
        {
            throw new IndexOutOfRangeException("startIndex must be non-negative");
        }

        if (count < 0)
        {
            throw new IndexOutOfRangeException("count must be non-negative");
        }

        if (count + startIndex > arr.Length)
        {
            throw new IndexOutOfRangeException("count + startIndex must be not greater than arr.length");
        }

        List<T> result = new List<T>();

        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    /// <summary>
    /// Returns extracted string by given string and number of symbols to extract
    /// </summary>
    /// <param name="str">the input string to be exctracted</param>
    /// <param name="count">the number of chars to be extracted from "str"</param>
    /// <returns>returns the extracted string(If the count is greater than the length of string, returns the whole string</returns>
    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentNullException("str must not be null or empty");
        }

        if (count < 0)
        {
            throw new IndexOutOfRangeException("count must be non-negative");
        }

        if (count > str.Length)
        {
            return str;
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("The number is not prime!");
            }
        }

        Console.WriteLine("The number is prime!");
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        CheckPrime(33);

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
