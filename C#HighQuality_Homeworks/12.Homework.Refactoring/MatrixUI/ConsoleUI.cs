namespace MatrixUI
{
    using System;
    using System.Text;

    using MatrixUI.Interfaces;

    public class ConsoleUI : IUserInterface
    {
        public int Read()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            return n;
        }

        public string Write(int[,] field)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    sb.AppendFormat("{0,3}", field[i, j]);
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb);

            return sb.ToString();
        }
    }
}
