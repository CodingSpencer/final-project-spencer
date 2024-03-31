# Stacks

Most beginning programmers know how to use basic lists very well when coding projects. However, 
sometimes there's a better alternative to hold the data in the program. One of these different
options is called stacks. A stack is a type of list that adds the most recent addition to the top
of the list and removes items from the same place. We'll discuss how this list works by looking
over an example, locating a related issue, and find a acceptable solution.

## Example

Let's begin by using the example of actually stacking pancakes. A stack has the same 
function of holding items of data, but differs from everyday lists in how those items 
are removed. It's last added, first removed. This means, just like if we were to stack 
pancakes, that we remove from the top of the stack. Which is its most recent addition
to the stack. To begin we need to create the new stack.

Example Code:
```csharp
// Create a new stack
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
```
Next let's experiment with adding and removing items from the stack. This option can be very helpful in many circumstances
if one is wanting that most recent item. Comes in handy when you're wanting that warmest pancake.

Example Code:
```csharp
// Stack Contents: french toast, banana pancake, peanut butter pancake, buttermilk pancake, chocolate chip pancake

// Remove the top two items from the stack
pancakes.Pop();
// Stack Contents: banana pancake, peanut butter pancake, buttermilk pancake, chocolate chip pancake
pancakes.Pop();
// Stack Contents: peanut butter pancake, buttermilk pancake, chocolate chip pancake

// Add another item and remove it
pancakes.Push(first);
// Stack Contents: chocolate chip pancake, peanut butter pancake, buttermilk pancake, chocolate chip pancake
pancakes.Pop();
// Stack Contents: peanut butter pancake, buttermilk pancake, chocolate chip pancake
```

## Problem

Now that we've covered what a stack is let's find a problem we can solve with them. If you've 
ever played checkers or chess you've most likely wished for an undo option. Now if you play on
an app, this option is usually programmed in. How could we use a stack to program this option?

Here's a template for the beginning of the project.

```csharp
Stack<string> checker_moves = new Stack<string>();

Console.WriteLine("Welcome to basic checkers game!\nPlease enter R to move right or L to move left.\nEnter U to undo your most recent move.\nEnter Q to quit the game.");
```

Here's a sample [solution](Program.cs) for you to compare with after you have completed your program.
