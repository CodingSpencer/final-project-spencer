// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Stack<string> keyboard = new Stack<string>();

List<string> words = new List<string>("steal", "stela", "tales", "least", "slate");

Random rand = new Random();
int randomIndex = rand.Next(0, words.Count);
string selectedWord = words[randomIndex];

Console.WriteLine("Welcome to the keyboard! Please attempt to spell the provided word. Select a character and push enter. When you want to remove the most recent added character select b and push enter.\nExtra: When you want to print your entry select p and push enter.");

// Write code that will create a user input based keyboard according to the print statment above


