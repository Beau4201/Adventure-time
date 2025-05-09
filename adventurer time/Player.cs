using System;
using System.Collections.Generic;

namespace adventurer_time
{
    public class Player : Entity
    {
        public List<Item> Inventory { get; private set; } = new List<Item>();

        public Player(string name, int health, int attack) : base(name, health, attack) { }

        // Add SetName method
        public void SetName(string name)
        {
            Name = name;
        }

        // Add GetName method
        public string GetName()
        {
            return Name;
        }

        public void AddItem(Item item)
        {
            Inventory.Add(item);
            Console.WriteLine($"You picked up: {item.Name}!");
        }

        public void PrintInventory()
        {
            Console.WriteLine("Your inventory:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }
    }

    public class Item
    {
        public string Name { get; private set; }
        public int AttackBoost { get; private set; }

        public Item(string name, int attackBoost)
        {
            Name = name;
            AttackBoost = attackBoost;
        }
    }
}

