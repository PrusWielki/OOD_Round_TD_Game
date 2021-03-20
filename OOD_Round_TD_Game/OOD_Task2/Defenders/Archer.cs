using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }
        public override int Attack(Ogre attacker)
        {
            if (arrows > 0)
            {
                Console.WriteLine($"Archer {name} attacks an Ogre {attacker.Name} dealing {strength} with an arrow");
                arrows--;
                return strength;
            }
            else
            {
                Console.WriteLine($"Archer {name} is out of arrows");
                return 0;
            }
        }
        public override int Attack(Rat attacker)
        {
            if (arrows > 0)
            {
                Console.WriteLine($"Archer {name} attacks a Rat {attacker.Name} dealing {strength} with an arrow");
                arrows--;
                return strength;
            }
            else
                return 0;
        }

        public override int Attack(Giant attacker)
        {
            if (arrows > 1)//not sure if archer should still be able to attack with 1 arrow
            {
                Console.WriteLine($"Archer {name} attacks a Giant {attacker.Name} twice dealing {2 * strength} with two arrows");
                arrows -= 2;

                return 2 * strength;
            }
            else
            {
                Console.WriteLine($"Archer {name} doesn't have enough arrows to attack a Giant");
                return 0;
            }
        }
    }
}