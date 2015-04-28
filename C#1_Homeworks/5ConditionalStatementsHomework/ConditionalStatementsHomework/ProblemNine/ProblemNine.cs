using System;

/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to enter an integer value, press \"1\"\nIf you want to enter a double value, press \"2\"\nIf you want to enter a string, press \"3\"");
            int choice = int.Parse(Console.ReadLine());
            int a;
            double b;
            string c;

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter integer value");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a+1);
                    break;
                
                case 2:
                    Console.WriteLine("Enter double value");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine(b+1);
                    break;
                
                case 3:
                    Console.WriteLine("Enter float value");
                    c = Console.ReadLine();
                    Console.WriteLine(c+"*");
                    break;
                
                default:
                    break;
            }
                    
        }
    }

