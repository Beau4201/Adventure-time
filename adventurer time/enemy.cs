using adventurer_time;

namespace adventurer_time
{
    public class Enemy : Entity
    {
        public Enemy(string name, int health, int attack) : base(name, health, attack) { }
    }

    public class Goblin : Enemy
    {
        public Goblin() : base("Goblin", 50, 10) { }
    }

    public class ShadowCreature : Enemy
    {
        public ShadowCreature() : base("Shadow Creature", 70, 15) { }

        public void UseDarkMagic()
        {
            Console.WriteLine("The Shadow Creature uses dark magic to weaken you!");
        }
    }

    public class Dragon : Enemy
    {
        public Dragon() : base("Dragon", 100, 20) { }

        public void BreatheFire()
        {
            Console.WriteLine("The Dragon breathes fire, dealing massive damage!");
        }
    }
}
