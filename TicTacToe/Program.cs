using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];
            makeBoard(board);
            int moves = 0;
            bool win = false;
            while (win == false)
            {
                printBoard(board);

                Console.Write($"Player {player} enter a row 1-3: ");
                int row = int.Parse(Console.ReadLine()) - 1;
                checkInput(row);
                Console.Write($"Player {player} enter a col 1-3: ");
                int col = int.Parse(Console.ReadLine()) - 1;
                checkInput(col);

                bool taken = false;
                while (taken == false)
                {
                    if (board[row, col] == '-')
                    {
                        board[row, col] = player;
                        taken = true;

                    }
                    else if (board[row, col] != '-')
                    {
                        Console.WriteLine("That spot is taken, you lose your turn!");
                        Console.Write($"Player {player} enter a row 1-3: ");
                        row = int.Parse(Console.ReadLine()) - 1;
                        checkInput(row);
                        Console.Write($"Player {player} enter a col 1-3: ");
                        col = int.Parse(Console.ReadLine()) - 1;
                        checkInput(col);
                    }
                }
                board[row, col] = player;

                win = didplayerWin(board, player);
                moves = moves + 1;
                movesTaken(moves);
                player = playerChange(player);

            }


        }
        public static string movesTaken(int moves)
        {
            if (moves == 9)
            {
            }
            return "It's a tie game!";

        }
        public static void checkInput(int input)
        {
            if (input < 0 || input > 3)
            {
                Console.WriteLine("Enter an integer from 1-3");
            }
        }
        public static bool didplayerWin(char[,] board, char player)
        {
            bool win = false;
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)//horizontal
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)//horizontal
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)//horizontal
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)//vertical
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)//vertical
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)//vertical
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) //diagonal
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)//diagonal
            {
                Console.WriteLine($"Player {player} won the game!");
                Console.ReadKey();
                win = true;
            }
            return win;
        }
        static char playerChange(char player)
        {
            if (player == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
        static void printBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void makeBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = '-';
                }
            }
        }

    }
}
