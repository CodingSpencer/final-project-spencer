// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> keyboard = new Stack<string>();

        List<string> words = new List<string>();
        words.Add("steal");
        words.Add("stela");
        words.Add("least");
        words.Add("slate");
        words.Add("tales");

        Random rand = new Random();
        int randomIndex = rand.Next(0, words.Count);
        string selectedWord = words[randomIndex];

        Console.WriteLine("Welcome to the keyboard!\nPlease attempt to spell the provided word. Select a character and push enter.\nWhen you want to remove the most recent added character select b and push enter.\nExtra: When you want to print your entry select p and push enter.");

        // Code to create a user input-based keyboard
    }
}
