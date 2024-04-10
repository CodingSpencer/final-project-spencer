// See https://aka.ms/new-console-template for more information

/* Let's begin introducing stacks by using the example of actually stacking pancakes.
A stack has the same function of holding items of data, but differs from everyday lists
in how those items are removed. It's last added, first removed. This means, just like
if we were to stack pancakes, that we remove from the top of the stack. Which is its
most recent addition to the stack.*/

// Create the new stack
using System;
using System.Reflection.Metadata;

Stack<String> pancakes = new Stack<string>();

// Create items to add to stack
string first = "chocolate chip pancake";
string second = "buttermilk pancake";
string third = "peanut butter pancake";
string fourth = "banana pancake";
string fifth = "french toast";

// Begin adding items (strings) into the stack
pancakes.Push(first);
pancakes.Push(second);
pancakes.Push(third);
pancakes.Push(fourth);
pancakes.Push(fifth);

// Print the contents of the stack to the console
Console.WriteLine(String.Join(", ", pancakes));

// Remove the top two items from the stack
pancakes.Pop();
pancakes.Pop();

Console.WriteLine(String.Join(", ", pancakes));

// Add another item and remove it
pancakes.Push(first);
Console.WriteLine(String.Join(", ", pancakes));

pancakes.Pop();
Console.WriteLine(String.Join(", ", pancakes));
