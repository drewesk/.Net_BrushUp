using System;

namespace OOPGame_8
{
    public class Warrior
    {
        // Name, Health, Attack Max Block Max
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Randomization with numbers
        Random rnd = new Random();

        public Warrior(string name = "Warrior",
                       double health = 0,
                       double attkMax = 0,
                       double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        // Attacking
        // Generate a random attack from 1 ot the Max
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        // Blocking
        // same as Attacking
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
