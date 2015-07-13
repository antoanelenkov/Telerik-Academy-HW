namespace MineGames
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        private const int Max = 35;

        static void Main()
        {
            string command = string.Empty;
            char[,] gameBoard = CreateGameBoard();
            char[,] bombs = LoadBombs();
            int counter = 0;
            bool isBomb = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool isGameStarted = true;
            bool isWinner = false;

            do
            {
                if (isGameStarted)
                {
                    Console.WriteLine("Lets play “Minesweeper”. Try your luck to not step onto a mine.");
                    Console.WriteLine("Commands: \n\t'top' -> show the scoreboard \n\t'restart' restart game \n\t'exit' quit game");

                    InitializeBombs(gameBoard);
                    isGameStarted = false;
                }

                Console.Write("Please enter row and column : ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= gameBoard.GetLength(0) && column <= gameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetScoreRanking(champions);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        bombs = LoadBombs();
                        InitializeBombs(gameBoard);
                        isBomb = false;
                        isGameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        {
                            if (bombs[row, column] != '*')
                            {
                                if (bombs[row, column] == '-')
                                {
                                    ProcessTurn(gameBoard, bombs, row, column);
                                    counter++;
                                }

                                if (Max == counter)
                                {
                                    isWinner = true;
                                }
                                else
                                {
                                    InitializeBombs(gameBoard);
                                }
                            }
                            else
                            {
                                isBomb = true;
                            }

                            break;
                        }

                    default:
                        Console.WriteLine("\nError! Invalid command");
                        break;
                }

                if (isBomb)
                {
                    InitializeBombs(bombs);

                    Console.Write("\nShit! Heroically died with a score of {0} points. Please enter a nickname: ", counter);

                    string playerNickname = Console.ReadLine();

                    Score playerScore = new Score(playerNickname, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < playerScore.Points)
                            {
                                champions.Insert(i, playerScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    GetScoreRanking(champions);

                    gameBoard = CreateGameBoard();
                    bombs = LoadBombs();
                    counter = 0;
                    isBomb = false;
                    isGameStarted = true;
                }

                if (isWinner)
                {
                    Console.WriteLine("\nNice! You've opened 35 cells without stepping onto a bomb.");

                    InitializeBombs(bombs);

                    Console.WriteLine("Please enter your nickname: ");

                    string nickname = Console.ReadLine();

                    Score score = new Score(nickname, counter);

                    champions.Add(score);
                    GetScoreRanking(champions);
                    gameBoard = CreateGameBoard();
                    bombs = LoadBombs();
                    counter = 0;
                    isWinner = false;
                    isGameStarted = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("See you.");

            Console.Read();
        }

        private static void GetScoreRanking(List<Score> score)
        {
            Console.WriteLine("\nScore:");

            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, score[i].Name, score[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No score results!\n");
            }
        }

        private static void ProcessTurn(char[,] gameField, char[,] bombs, int row, int column)
        {
            char bombsCount = GetBombsCount(bombs, row, column);
            bombs[row, column] = bombsCount;
            gameField[row, column] = bombsCount;
        }

        private static void InitializeBombs(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;

            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] LoadBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameBoard = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> loadedBombs = new List<int>();

            while (loadedBombs.Count < 15)
            {
                Random random = new Random();

                int randomNumber = random.Next(50);

                if (!loadedBombs.Contains(randomNumber))
                {
                    loadedBombs.Add(randomNumber);
                }
            }

            foreach (int bomb in loadedBombs)
            {
                int currentCol = (bomb / cols);
                int currentRow = (bomb % cols);

                if (currentRow == 0 && bomb != 0)
                {
                    currentCol--;
                    currentRow = cols;
                }
                else
                {
                    currentRow++;
                }

                gameBoard[currentCol, currentRow - 1] = '*';
            }

            return gameBoard;
        }

        private static void CheckField(char[,] gameBoard)
        {
            int colCount = gameBoard.GetLength(0);
            int rowCount = gameBoard.GetLength(1);

            for (int i = 0; i < colCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    if (gameBoard[i, j] != '*')
                    {
                        char bombsCount = GetBombsCount(gameBoard, i, j);
                        gameBoard[i, j] = bombsCount;
                    }
                }
            }
        }

        private static char GetBombsCount(char[,] mines, int row, int col)
        {
            int count = 0;
            int rows = mines.GetLength(0);
            int kols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < kols)
            {
                if (mines[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < kols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < kols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
