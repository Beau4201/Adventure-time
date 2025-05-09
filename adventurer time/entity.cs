namespace adventurer_time
{
    public class Entity
    {
        // Common properties for both Player and Enemy
        public string Name { get; protected set; } // Changed to protected set
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Attack { get; set; }

        // Constructor to initialize the entity
        public Entity(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Attack = attack;
        }

        // Method to take damage
        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        // Method to heal
        public void Heal(int amount)
        {
            Health += amount;
            if (Health > MaxHealth) Health = MaxHealth;
        }
    }

}
}

