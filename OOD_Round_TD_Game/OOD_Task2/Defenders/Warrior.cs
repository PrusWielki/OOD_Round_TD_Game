using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

      // string IDefender.name { get { return name; } }

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }
        public virtual int Attack(Ogre attacker)
        {
            Console.WriteLine($"Warrior {name} attacks an Ogre {attacker.Name} dealing {strength}");
            
            return strength;

        }
        public virtual int Attack(Giant attacker)
        {
            Console.WriteLine($"Warrior {name} attacks a Giant {attacker.Name} dealing {strength}");
            return strength;

        }
        public virtual int Attack(Rat attacker)
        {
            //double r = rng.NextDouble();
            //double c = (double)attacker.Speed / (double)100;
            if (rng.NextDouble() < (double)attacker.Speed / (double)100) //says that casts are redundant, but without them the result of right hand side is 0
            {
                Console.WriteLine($"Warrior {name} misses a Rat {attacker.Name}");
                return 0;
            }
            else
            {
                Console.WriteLine($"Warrior {name} attacks a Rat {attacker.Name} dealing {strength}");
                return strength;
            }

        }
    }
}