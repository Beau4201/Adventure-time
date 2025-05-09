using System;
using adventurer_time;

public class AdventureLeft
{
    private Player player;

    public AdventureLeft()
    {
        player = new Player("Hero", 100, 20);
    }

    private void ArtifactOfPower()
    {
        Item artifact = new Item("Artifact Of Power", 15);
        player.AddItem(artifact);
        PrintSlowly("You found the Artifact of Power! Your attack power has increased.");
    }

    private void StarterSword()
    {
        Item sword = new Item("Starter Sword", 0);
        player.AddItem(sword);
        PrintSlowly("You found a Starter Sword! Your attack power has increased.");
    }

    public void ContinueLeftPath()
    {
        PrintSlowly("You wake up in a dimly lit cave, the air damp and cold.");
        PrintSlowly("The faint sound of dripping water echoes around you.");
        PrintSlowly("You feel a sharp pain in your head and realize you can't remember how you got here.");
        PrintSlowly("As you stand up, you notice a faint glow coming from deeper within the cave.");
        PrintSlowly("You cautiously move toward the light and find a treasure chest.");
        PrintSlowly("You open the chest and find a sword, its blade shimmering faintly in the darkness.");
        StarterSword();
        PrintSlowly("Suddenly, you hear a low growl behind you.");
        PrintSlowly("You turn around and see a shadowy figure emerging from the darkness.");
        PrintSlowly("What would you like to do?");
        PrintSlowly("1. Fight\n2. Run");

        string choice = GetValidInput(new[] { "1", "2" });
        if (choice == "1") FightGoblin();
        else RunFromMonster();
    }

    private void FightGoblin()
    {
        Goblin goblin = new Goblin();
        PrintSlowly($"A wild {goblin.Name} appears with {goblin.Health} HP!");

        while (player.Health > 0 && goblin.Health > 0)
        {
            PrintSlowly("1. Attack\n2. Heal\n3. Taunt");
            string action = GetValidInput(new[] { "1", "2", "3" });

            if (action == "1")
            {
                goblin.TakeDamage(player.Attack);
                PrintSlowly($"You attack the {goblin.Name} for {player.Attack} damage!");
            }
            else if (action == "2")
            {
                player.Heal(20);
            }
            else if (action == "3")
            {
                PrintSlowly($"You taunt the {goblin.Name}, making it angrier!");
            }

            if (goblin.Health > 0)
            {
                player.TakeDamage(goblin.Attack);
                PrintSlowly($"The {goblin.Name} attacks you for {goblin.Attack} damage!");
            }
        }

        if (player.Health > 0)
        {
            PrintSlowly($"You defeated the {goblin.Name}!");
            ContinueAdventure();
        }
        else
        {
            PrintSlowly("You have been defeated. Game Over!");
        }
    }

    private void RunFromMonster()
    {
        PrintSlowly("You try to run away, but the monster catches you!");
        FightGoblin();
    }

    private void ContinueAdventure()
    {
        PrintSlowly("You continue your journey and find a fork in the road.");
        PrintSlowly("1. Take the left path\n2. Take the right path");

        string choice = GetValidInput(new[] { "1", "2" });
        if (choice == "1")
        {
            PrintSlowly("You take the left path and find a peaceful village.");
        }
        else
        {
            PrintSlowly("You take the right path and encounter a dark forest.");
        }
    }

    private string GetValidInput(string[] validOptions)
    {
        string input;
        do
        {
            input = Console.ReadLine() ?? "";
        } while (!Array.Exists(validOptions, option => option == input));
        return input;
    }

    private void PrintSlowly(string message, int delay = 30, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        foreach (char c in message)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(delay);
        }
        Console.WriteLine();
        Console.ResetColor();
    }
}
