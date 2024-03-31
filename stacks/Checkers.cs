using System;

// Code By ChatGPT
namespace CheckersGame
{
    class Checkers
    {
static char[,] board;
        static int boardSize = 8; // Standard checkers board size

        static void Main(string[] args)
        {
            InitializeBoard();
            PrintBoard();

            // Game loop
            while (true)
            {
                // Player 1's turn
                PlayerTurn('X');

                // Check for win condition
                if (CheckWin('X'))
                {
                    Console.WriteLine("Player 1 wins!");
                    break;
                }

                // Player 2's turn
                PlayerTurn('O');

                // Check for win condition
                if (CheckWin('O'))
                {
                    Console.WriteLine("Player 2 wins!");
                    break;
                }
            }
        }

        static void InitializeBoard()
        {
            board = new char[boardSize, boardSize];
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    // Place pieces on alternating dark squares
                    if ((row + col) % 2 == 1)
                    {
                        if (row < 3)
                            board[row, col] = 'X'; // Player 1's pieces
                        else if (row > 4)
                            board[row, col] = 'O'; // Player 2's pieces
                        else
                            board[row, col] = ' '; // Empty square
                    }
                    else
                    {
                        board[row, col] = ' '; // Light squares are empty
                    }
                }
            }
        }

        static void PrintBoard()
        {
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PlayerTurn(char player)
        {
            Console.WriteLine($"Player {player} turn:");

            // Code for player's move goes here

            PrintBoard(); // Print the board after each move
        }

        static bool CheckWin(char player)
        {
            // Code to check for win condition (no more opponent's pieces left) goes here
            return false; // Placeholder, replace with actual win condition check
        }
    }
}