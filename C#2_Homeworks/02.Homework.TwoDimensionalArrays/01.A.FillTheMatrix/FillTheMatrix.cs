using System;

/*Write a program that fills and prints a matrix of size (n, n) as shown below:

1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
 */

class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for size of matrix:");
        int n = int.Parse(Console.ReadLine());


        for (int i = 1; i <= n; i++)
        {
            int startNumber = i;
            for (int j = 1; j <= n; j++)
            {
                Console.Write (startNumber.ToString().PadRight(3)+" ");
                startNumber += n;
            }
            Console.WriteLine();
        }
    }
}
