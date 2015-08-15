namespace MatrixUI
{
    using MatrixTask;
    using MatrixUI.Interfaces;

    internal class MatrixProceeder
    {
        static void Main(string[] args)
        {
            IUserInterface consoleUI = new ConsoleUI();

            int input = consoleUI.Read();

            RotatingMatrixSolver matrix = new RotatingMatrixSolver(input);

            consoleUI.Write(matrix.Field);
        }
    }
}
