using System;

//	Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//	The card faces should start from 2 to A.
//	Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output
//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds


namespace ProblemFour
{
    class PrintCards
    {
        static void Main(string[] args)
        {
            String a = "of Diamonds";
            String b = "of Hearts";
            String c = "of Clubs";
            String d = "of Spades";


            for (int i = 2; i <= 14; i++)
            {
                if (i <= 10)
                {
                    for (int m = 1; m <= 4; m++)
                    {
                        if (m == 1) { Console.WriteLine(i + " " + a); }
                        if (m == 2) { Console.WriteLine(i + " " + b); }
                        if (m == 3) { Console.WriteLine(i + " " + c); }
                        if (m == 4) { Console.WriteLine(i + " " + d); }
                    }
                }


                if (i == 11)
                {
                    for (int m = 1; m <= 4; m++)
                    {
                        if (m == 1) { Console.WriteLine("V " + a); }
                        if (m == 2) { Console.WriteLine("V " + b); }
                        if (m == 3) { Console.WriteLine("V " + c); }
                        if (m == 4) { Console.WriteLine("V " + d); }
                    }
                }

                if (i == 12)
                {
                    for (int m = 1; m <= 4; m++)
                    {
                        if (m == 1) { Console.WriteLine("D " + a); }
                        if (m == 2) { Console.WriteLine("D " + b); }
                        if (m == 3) { Console.WriteLine("D " + c); }
                        if (m == 4) { Console.WriteLine("D " + d); }
                    }
                }

                if (i == 13)
                {
                    for (int m = 1; m <= 4; m++)
                    {
                        if (m == 1) { Console.WriteLine("K " + a); }
                        if (m == 2) { Console.WriteLine("K " + b); }
                        if (m == 3) { Console.WriteLine("K " + c); }
                        if (m == 4) { Console.WriteLine("K " + d); }
                    }
                }

                if (i == 14)
                {
                    for (int m = 1; m <= 4; m++)
                    {
                        if (m == 1) { Console.WriteLine("A " + a); }
                        if (m == 2) { Console.WriteLine("A " + b); }
                        if (m == 3) { Console.WriteLine("A " + c); }
                        if (m == 4) { Console.WriteLine("A " + d); }
                    }
                }


            }
        }
    }
}
