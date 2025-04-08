using adventurer_time;
using System;
using System.Security.Principal;

public class AdventureLeft
{
    
    // Entry point for the left path adventure

    private void PrintSlowly(string message, int delay = 30)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine();
    }
    //https://cults3d.com/en/3d-model/various/correct-doggy-style-funny-sign

    Player player;
    public void ContinueLeftPath()
    {
        player = new Player();
        
        Console.ForegroundColor = ConsoleColor.White;
        PrintSlowly("You went left and found a treasure chest!");
        PrintSlowly("You open the chest and find a sword!");
        PrintSlowly("You pick up the sword and continue on your journey.");
        PrintSlowly("You find a monster. What would you like to do?");
        PrintSlowly("1. Fight");
        PrintSlowly("2. Run");

        // Get the user's choice and validate it
        string ?initialChoice = Console.ReadLine();
        while (initialChoice != "1" && initialChoice != "2")
        {
            PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
            PrintSlowly("1. Fight");
            PrintSlowly("2. Run");
            initialChoice = Console.ReadLine();
        }

        // Handle the user's choice
        if (initialChoice == "1")
        {
            FightMonster();
        }
        else if (initialChoice == "2")
        {
            RunFromMonster();
        }

        Console.ResetColor();
    }

   

    // Method to handle fighting the monster
    private void FightMonster()
    {
        PrintSlowly("You fight the monster and win!");
        PrintSlowly("You continue on your journey.");
        PrintSlowly("You find a road. What do you do?");
        PrintSlowly("1. Follow the road");
        PrintSlowly("2. Go back to the forest");

        // Get the user's choice and validate it
        string ?roadChoice = Console.ReadLine();
        while (roadChoice != "1" && roadChoice != "2")
        {
            PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
            PrintSlowly("1. Follow the road");
            PrintSlowly("2. Go back to the forest");
            roadChoice = Console.ReadLine();
        }

        // Handle the user's choice
        if (roadChoice == "1")
        {
            PrintSlowly("You follow the road and find a village.");
            PrintSlowly("You find the leader of the village.");
            PrintSlowly("What would you like to do?");
            PrintSlowly("1. Talk to the leader");
            PrintSlowly("2. Ignore the leader");
            string ?leaderChoice = Console.ReadLine();

            // Loop to validate the user's choice
            while (leaderChoice != "1" && leaderChoice != "2")
            {
                PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
                PrintSlowly("1. Talk to the leader");
                PrintSlowly("2. Ignore the leader");
                leaderChoice = Console.ReadLine();
            }

            if (leaderChoice == "1")
            {
                PrintSlowly("You talk to the leader and he gives you a quest.");
                PrintSlowly("Do you accept the quest?");
                PrintSlowly("1. Accept");
                PrintSlowly("2. Decline");
                string ?questChoice = Console.ReadLine();

                while (questChoice != "1" && questChoice != "2")
                {
                    PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
                    PrintSlowly("1. Accept");
                    PrintSlowly("2. Decline");
                    questChoice = Console.ReadLine();
                }

                if (questChoice == "1")
                {
                    PrintSlowly("You accept the quest and go on an adventure.");
                    PrintSlowly("He wants you to find the hidden stone of Strikliklan.");
                    PrintSlowly("He tells you that the stone can be found in the Strikliklan's base.");
                    PrintSlowly("You figure it is to the north and you follow the path to the clan.");
                    PrintSlowly("You keep walking until you see a big cloud of smoke above some big trees.");
                    PrintSlowly("You see a big dragon flying above the trees.");
                    PrintSlowly("You decide to ignore it.");
                    PrintSlowly("You keep walking until you see a big gate.");
                    PrintSlowly("You see a guard and you ask him where the stone is.");
                    PrintSlowly("He tells you that the stone is in the dragon's cave.");
                    PrintSlowly("You go to the cave and you see the dragon sleeping.");
                    PrintSlowly("You see the stone and you try to take it.");
                    PrintSlowly("The dragon wakes up and it looks like you have to fight it.");
                    PrintSlowly("A girl comes running to you, she tells you to come with her");
                    PrintSlowly("What do you do");
                    PrintSlowly("1. Go with her");
                    PrintSlowly("2. Fight the dragon");
                    string ?dragonChoice = Console.ReadLine();

                    while (dragonChoice != "1" && dragonChoice != "2")
                    {
                        PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
                        PrintSlowly("1. Go with her");
                        PrintSlowly("2. Fight the dragon");
                        dragonChoice = Console.ReadLine();
                    }
                    if (dragonChoice == "1")
                    {
                        PrintSlowly("You go with her and barely escape the dragon.");
                        // more story, do later
                    }
                    else if (dragonChoice == "2")
                    {
                        PrintSlowly("You fight the dragon and die.");
                        PrintSlowly("You died!");
                        // end game
                    }
                }
                else if (questChoice == "2")
                {
                    PrintSlowly("You decline the quest and leave the village.");
                    PrintSlowly("You wander aimlessly and eventually get lost.");
                    PrintSlowly("You keep walking");
                    PrintSlowly("And walking");
                    PrintSlowly("And walking...");
                    PrintSlowly("You eventually find a giant...");
                    PrintSlowly("He starts talking to you.");
                    PrintSlowly("He tells you that he's lost and wants to go back to his wife");
                    PrintSlowly("He then tells you that he's really hungry");
                    PrintSlowly("The giant then proceeds to slam you to the ground and eats you alive");
                    PrintSlowly("You died");
                    // make more story
                }
            }
            else if (leaderChoice == "2")
            {
                PrintSlowly("You ignore the leader and leave the village.");
                PrintSlowly("You wander aimlessly and eventually get lost. You died!");
                // make more story
            }
        }
        else if (roadChoice == "2")
        {
            PrintSlowly("You go back to the forest and get lost. You died!");
            // make more story
        }
    }

    // Method to handle running from the monster
    private void RunFromMonster()
    {
        PrintSlowly("You run away and fall. The monster catches you. What do you do now?");
        PrintSlowly("1. Fight");
        PrintSlowly("2. Give up");

        // Get the user's choice and validate it
        string ?monsterChoice = Console.ReadLine();
        while (monsterChoice != "1" && monsterChoice != "2")
        {
            PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
            PrintSlowly("1. Fight");
            PrintSlowly("2. Give up");
            monsterChoice = Console.ReadLine();
        }

        // Handle the user's choice
        if (monsterChoice == "1")
        {
            FightDragon();
        }
        else if (monsterChoice == "2")
        {
            PrintSlowly("You give up and the monster eats you!");
            PrintSlowly("You died!");
            // end
        }
    }

    // Method to handle fighting the dragon
    private void FightDragon()
    {
        PrintSlowly("You fight the monster and win!");
        PrintSlowly("You continue on your journey.");
        PrintSlowly("You find a dragon. What would you like to do?");
        PrintSlowly("1. Fight");
        PrintSlowly("2. Run");
        PrintSlowly("3. Steal its egg");

        // Get the user's choice and validate it
        string ?dragonChoice = Console.ReadLine();
        while (dragonChoice != "1" && dragonChoice != "2" && dragonChoice != "3")
        {
            PrintSlowly("You didn't choose a valid option! Please choose either '1', '2', or '3'.");
            PrintSlowly("1. Fight");
            PrintSlowly("2. Run");
            PrintSlowly("3. Steal its egg");
            dragonChoice = Console.ReadLine();
        }

        // Handle the user's choice
        if (dragonChoice == "1")
        {
            FightDragonFire();
        }
        else if (dragonChoice == "2")
        {
            PrintSlowly("You run away and the dragon eats you!");
            PrintSlowly("You died!");
        }
        else if (dragonChoice == "3")
        {
            PrintSlowly("You steal the dragon's egg and it chases you!");
            PrintSlowly("You run away and escape!");
            PrintSlowly("You run to the other side of the forest");
            PrintSlowly("You find a village. What would you like to do?");
            PrintSlowly("1. Enter the village");
            PrintSlowly("2. Ignore the village");
            string ?dragonVillage = Console.ReadLine();


            while (dragonVillage != "1" && dragonVillage != "2")
            {
                PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
                PrintSlowly("1. Enter the village");
                PrintSlowly("2. Ignore the village");
                dragonVillage = Console.ReadLine();
            }

            if (dragonVillage == "1")
            {
                PrintSlowly("The village chief sees your egg and is interested.");
                PrintSlowly("He offers you a reward for the egg.");
                PrintSlowly("Something tells you that giving the egg away seems like a bad idea");
                PrintSlowly("What do you do?");
                PrintSlowly("1. Give the egg to the chief");
                PrintSlowly("2. Keep the egg");
                string ?eggChoice = Console.ReadLine();


                if (eggChoice == "2")
                {
                    player.healthPoints -= 13;
                    PrintSlowly("You keep the egg and the dragon finds you.");
                    PrintSlowly("The dragon is angry and attacks you.");
                    PrintSlowly($"You dodge the attack but you take 13 damage.");
                    PrintSlowly($"You have {player.healthPoints} HP left");
                    PrintSlowly("You run under the dragon and get to a river");
                    PrintSlowly("You see a boat and you get in it");
                    PrintSlowly("You see the dragon flying over you");
                    PrintSlowly("You see a waterfall and you go down it");
                    PrintSlowly("You fell down and took 2 damage!");
                    PrintSlowly($"You have {player.healthPoints - 2} HP left");


                }
                else if (eggChoice == "1")
                {
                    PrintSlowly("You keep the egg and the dragon finds you.");
                    PrintSlowly("The dragon is angry and attacks you.");
                    PrintSlowly("You fight the dragon and die.");
                    PrintSlowly("You died!");
                }
            }

            else if (dragonVillage == "2")
            {
                PrintSlowly("You ignore the village and continue your journey.");
                PrintSlowly("You find a cave and enter it.");
                PrintSlowly("You find a treasure chest and open it.");
                PrintSlowly("You find a map inside the chest.");
                PrintSlowly("You follow the map and find a hidden treasure!");
                PrintSlowly("You find a passage that seems nearly impossible to pass thrue.");
                PrintSlowly("You see a big rock and you push it.");
            }
        }
    }

    // Method to handle fighting the dragon's fire
    private void FightDragonFire()
    {
        PrintSlowly("You fight the dragon and it spits fire!");
        PrintSlowly("You dodge the fire and escape!");
        PrintSlowly("You run back to the forest.");
        PrintSlowly("You find a map. What would you like to do?");
        PrintSlowly("1. Follow the map");
        PrintSlowly("2. Ignore the map");

        // Get the user's choice and validate it
        string ?mapChoice = Console.ReadLine();
        while (mapChoice != "1" && mapChoice != "2")
        {
            PrintSlowly("You didn't choose a valid option! Please choose either '1' or '2'.");
            PrintSlowly("1. Follow the map");
            PrintSlowly("2. Ignore the map");
            mapChoice = Console.ReadLine();
        }

        // Handle the user's choice
        if (mapChoice == "1")
        {
            PrintSlowly("You follow the map and find a hidden treasure!");
            PrintSlowly("You win the game!");
            //more story, do later
        }
        else if (mapChoice == "2")
        {
            PrintSlowly("You ignore the map and get lost in the forest.");
            PrintSlowly("You died!");
            // more story, do later
        }
    }

    // Method to print text slowly

}
