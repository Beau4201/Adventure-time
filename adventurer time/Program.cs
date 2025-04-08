using System;
using System.Threading;

void PrintSlowly(string message, int delay = 30)
{
    foreach (char c in message)
    {
        Console.Write(c);
        Thread.Sleep(delay);
    }
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.White;
PrintSlowly("What is your username? : ");
string Username = Console.ReadLine();
PrintSlowly($"Hello {Username}, welcome to the Forest!");

PrintSlowly("You are in a forest, you can go left or right. Which way would you like to go? : ");
string Direction = Console.ReadLine();
while (Direction != "left" && Direction != "right")
{
    PrintSlowly("You didn't choose a valid direction! Please choose either 'left' or 'right'.");
    Direction = Console.ReadLine();
}

if (Direction == "left")
{
    AdventureLeft adventureLeft = new AdventureLeft();
    adventureLeft.ContinueLeftPath();
}
else if (Direction == "right")
{
    PrintSlowly("You went right and found a monster!");
}

Console.ResetColor();

