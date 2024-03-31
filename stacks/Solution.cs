// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Stack<string> checker_moves = new Stack<string>();

Console.WriteLine("Welcome to basic checkers game! \nPlease enter R to move right or L to move left. \nEnter U to undo your most recent move. \nEnter Q to quit the game.");

while (true)
{
    string move = Console.ReadLine().ToUpper();
    
    if (checker_moves.Count > 1 & move.ToUpper() == "U")
    {
        string last_move = checker_moves.Pop();
        Console.WriteLine($"Last {last_move} move removed.");
    }
    else if (move.Length == 1 & (move.ToUpper() == "R" || move.ToUpper() == "L"))
    {
        checker_moves.Push(move);
        Console.WriteLine("Player 2 went. Select your next turn.");

    }
    else if (move.ToUpper() == "Q")
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid move! Try again.");
    }
}


