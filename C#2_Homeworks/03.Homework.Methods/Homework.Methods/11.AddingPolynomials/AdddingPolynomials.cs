using System;

/*
 * Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 */

class AdddingPolynomials
{
    static int[] GetCoeficients(int[] polyOne, int[] polyTwo)
    {
        int[] polyResult = new int[3];
        for (int i = 0; i < polyOne.Length; i++)
        {
            polyResult[i] = polyOne[i] + polyTwo[i];
        }
        return polyResult;
    }

    static void Main(string[] args)
    {
        int[] polyOne = new int[3];
        int[] polyTwo = new int[3];

        for (int i = 0; i < polyOne.Length; i++)
        {
            Console.Write("Enter coeficient \"{0}\" for the first polynom:",i+1);
            polyOne[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < polyTwo.Length; i++)
        {
            Console.Write("Enter coeficient \"{0}\" for the second polynom:",i+1);
            polyTwo[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Result coeficients are:");
        Console.Write("{");
        Console.Write(String.Join(", ",GetCoeficients(polyOne,polyTwo)));
        Console.WriteLine("}");
     

    }
}

