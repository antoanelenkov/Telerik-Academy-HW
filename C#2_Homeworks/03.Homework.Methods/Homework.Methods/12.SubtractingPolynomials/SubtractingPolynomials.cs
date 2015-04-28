using System;

//Extend the previous program to support also subtraction and multiplication of polynomials.

class SubtractingPolynomials
{
    static int[] GetAddedCoeficients(int[] polyOne, int[] polyTwo)
    {
        int[] polyResult = new int[3];
        for (int i = 0; i < polyOne.Length; i++)
        {
            polyResult[i] = polyOne[i] + polyTwo[i];
        }
        return polyResult;
    }

    static int[] GetSubtractedCoeficients(int[] polyOne, int[] polyTwo)
    {
        int[] polyResult = new int[3];
        for (int i = 0; i < polyOne.Length; i++)
        {
            polyResult[i] = polyOne[i] - polyTwo[i];
        }
        return polyResult;
    }

    static void Main(string[] args)
    {
        int[] polyOne = new int[3];
        int[] polyTwo = new int[3];

        for (int i = 0; i < polyOne.Length; i++)
        {
            Console.Write("Enter coeficient \"{0}\" for the first polynom:", i + 1);
            polyOne[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < polyTwo.Length; i++)
        {
            Console.Write("Enter coeficient \"{0}\" for the second polynom:", i + 1);
            polyTwo[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Result coeficients from addind are:");
        Console.Write("{");
        Console.Write(String.Join(", ", GetAddedCoeficients(polyOne, polyTwo)));
        Console.WriteLine("}");

        Console.WriteLine("Result coeficients from subtracting are:");
        Console.Write("{");
        Console.Write(String.Join(", ", GetSubtractedCoeficients(polyOne, polyTwo)));
        Console.WriteLine("}");

    }
}

