using System;
using System.Threading;
using System.Collections.Generic;
using adventurer_time; // Ensure the namespace for Player, Enemy, Entity, and Item is included

class Program
{
    static void Main(string[] args)
    {
        // PrintSlowly method
        void PrintSlowly(string message, int delay = 30, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    // Skip the delay and print the rest of the message instantly
                    Console.Write(message.Substring(message.IndexOf(c)));
                    break;
                }
                Console.Write(c);
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        // Initialize the player
        Player player = new Player("Adventurer", 100, 20); // Fixed Player initialization
        PrintSlowly("What is your username? : ");
        string? Username = Console.ReadLine();
        player.SetName(Username ?? "Adventurer");
        PrintSlowly($"Hello {player.GetName()}, welcome to the Forest!");

        // Initial choice
        PrintSlowly("You are in a forest, you can go left or right. Which way would you like to go? : ");
        string? Direction = Console.ReadLine();
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
            Enemy goblin = new Enemy("Goblin", 50, 10); // Fixed Enemy initialization
            PrintSlowly($"A wild {goblin.Name} appears with {goblin.Health} HP and {goblin.Attack} attack power!");

            PrintSlowly("You can either fight or run away. What do you want to do? : ");
            string? Action = Console.ReadLine();

            while (Action != "fight" && Action != "run")
            {
                PrintSlowly("You didn't choose a valid action! Please choose either 'fight' or 'run'.");
                Action = Console.ReadLine();
            }

            if (Action == "fight")
            {
                FightEnemy(goblin);
                if (player.Health > 0)
                {
                    PrintSlowly("Congratulations, you defeated the goblin!");
                    RightPathAdventure();
                }
            }
            else if (Action == "run")
            {
                PrintSlowly("You ran away safely, but the monster is still out there.");
                PrintSlowly("Maybe next time you'll be brave enough to fight!");
            }
        }

        Console.ResetColor();

        // FightEnemy method
        void FightEnemy(Enemy enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                PrintSlowly("What will you do?");
                PrintSlowly("1. Attack\n2. Heal");
                string? Action = Console.ReadLine();

                if (Action == "1")
                {
                    enemy.TakeDamage(player.Attack);
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintSlowly($"You attack the {enemy.Name} for {player.Attack} damage!");
                    Console.ResetColor();
                }
                else if (Action == "2")
                {
                    player.Heal(20);
                }
                else
                {
                    PrintSlowly("Invalid action! You lose your turn.");
                }

                if (enemy.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintSlowly($"You defeated the {enemy.Name}!");
                    Console.ResetColor();
                    break;
                }

                player.TakeDamage(enemy.Attack);
                Console.ForegroundColor = ConsoleColor.Red;
                PrintSlowly($"The {enemy.Name} attacks you for {enemy.Attack} damage!");
                Console.ResetColor();

                if (player.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintSlowly("You have been defeated. Game Over!");
                    Console.ResetColor();
                    break;
                }
            }
        }

        // RightPathAdventure method
        void RightPathAdventure()
        {
            PrintSlowly("After defeating the monster, you find a mysterious cave.");
            PrintSlowly("Do you want to enter the cave? (yes/no) : ");
            string? EnterCave = Console.ReadLine();

            while (EnterCave != "yes" && EnterCave != "no")
            {
                PrintSlowly("You didn't choose a valid option! Please choose either 'yes' or 'no'.");
                EnterCave = Console.ReadLine();
            }

            if (EnterCave == "yes")
            {
                PrintSlowly("You enter the cave and find a treasure chest.");
                PrintSlowly("Do you want to open the chest? (yes/no) : ");
                string? OpenChest = Console.ReadLine();

                while (OpenChest != "yes" && OpenChest != "no")
                {
                    PrintSlowly("You didn't choose a valid option! Please choose either 'yes' or 'no'.");
                    OpenChest = Console.ReadLine();
                }

                if (OpenChest == "yes")
                {
                    PrintSlowly("You open the chest and find a Magical Sword!");
                    Item magicalSword = new Item("Magical Sword", 10); // Fixed Item initialization
                    player.AddItem(magicalSword);
                }
                else
                {
                    PrintSlowly("You decide not to open the chest and leave the cave.");
                }
            }
            else
            {
                PrintSlowly("You decide not to enter the cave and continue your journey.");
            }

            PrintSlowly("As you continue your journey, you encounter a fork in the road.");
            PrintSlowly("Do you want to go left or right? : ");
            string? ForkChoice = Console.ReadLine();

            while (ForkChoice != "left" && ForkChoice != "right")
            {
                PrintSlowly("You didn't choose a valid direction! Please choose either 'left' or 'right'.");
                ForkChoice = Console.ReadLine();
            }

            if (ForkChoice == "left")
            {
                PrintSlowly("You take the left path and find a small village.");
                PrintSlowly("The villagers welcome you and offer you food and shelter.");
                PrintSlowly("You decide to stay in the village and live a peaceful life.");
            }
            else
            {
                PrintSlowly("You take the right path and encounter a fierce dragon!");
                Enemy dragon = new Enemy("Dragon", 100, 20); // Fixed Enemy initialization
                PrintSlowly($"A {dragon.Name} appears with {dragon.Health} HP and {dragon.Attack} attack power!");

                PrintSlowly("Do you want to fight the dragon or run away? (fight/run) : ");
                string? DragonChoice = Console.ReadLine();

                while (DragonChoice != "fight" && DragonChoice != "run")
                {
                    PrintSlowly("You didn't choose a valid action! Please choose either 'fight' or 'run'.");
                    DragonChoice = Console.ReadLine();
                }

                if (DragonChoice == "fight")
                {
                    FightEnemy(dragon);
                    if (player.Health > 0)
                    {
                        PrintSlowly("You bravely fight the dragon and emerge victorious!");
                        PrintSlowly("You are hailed as a hero throughout the land!");
                    }
                }
                else
                {
                    PrintSlowly("You run away from the dragon and live to fight another day.");
                }
            }
        }
    }
}
