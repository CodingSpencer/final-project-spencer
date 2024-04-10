// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> keyboard = new Stack<string>();
        List<string> words = new List<string> { "steal", "stela", "tales", "least", "slate" };

        Random rand = new Random();
        int randomIndex = rand.Next(0, words.Count);
        string selectedWord = words[randomIndex];

        Console.WriteLine("Welcome to the keyboard! Please attempt to spell the provided word. Select a character and push enter. When you want to remove the most recent added character select b and push enter.\nExtra: When you want to print your entry select p and push enter.");
        Console.WriteLine($"Please attempt to spell {selectedWord}!");

	string character;

        while (true)
	{
	    Console.Write("Enter a Character: ");
	    character = Console.ReadLine();

	    if (character == "b")
	    {
			if (keyboard.Count > 0)
			{
				keyboard.Pop();
			}
			else
			{
				Console.WriteLine("Keyboard is empty!");
			}
	    }
	    else if (character == "p")
	    {
		break; // Exit the loop if "p" is entered
	    }
		else if (character.Length == 1 && char.IsLetter(character[0])) // Check if input is a single letter
	    {
		keyboard.Push(character);
	    }
	    else
	    {
		Console.WriteLine("Invalid input. Please enter a single letter, 'b', or 'p'.");
	    }
	}


        Stack<string> print = new Stack<string>();

        while (keyboard.Count != 0)
        {
            print.Push(keyboard.Pop());
        }

        string printWord = string.Join("", print);

        if (printWord != selectedWord)
        {
            Console.WriteLine("You Lose!");
        }
        else
        {
            Console.WriteLine($"Congratulations you spelled {printWord} correctly!");
        }
    }
}
