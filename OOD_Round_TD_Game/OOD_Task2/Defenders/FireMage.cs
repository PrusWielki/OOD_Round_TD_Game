using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private double killChance;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, double killChance) : base(name, mana, manaRegen, spellPower)
        {
            this.killChance = killChance;
        }
        public override int Attack(Ogre attacker)
        {
            if (rng.NextDouble() < killChance)
            {
                Console.WriteLine($"FireMage {name} performs an insta kill on an Ogre {attacker.Name}");
                return attacker.HP+attacker.Armor;
            }
            else
            {
                Console.WriteLine($"FireMage {name} attacks an Ogre {attacker.Name} dealing {spellPower}");
                return spellPower;
            }
        }
        public override int Attack(Giant attacker)
        {

            if (rng.NextDouble() < killChance) {
                Console.WriteLine($"FireMage {name} performs an insta kill on a Giant {attacker.Name}");

                return attacker.HP; }
            else
            {
                Console.WriteLine($"FireMage {name} attacks a Giant {attacker.Name} dealing {spellPower}");
                return spellPower;
            }
        }
        public override int Attack(Rat attacker)
        {

            if (rng.NextDouble() < killChance)
            {
                Console.WriteLine($"FireMage {name} performs an insta kill on a Rat {attacker.Name}");
                return attacker.HP;
            }
            else
            {
                Console.WriteLine($"FireMage {name} attacks a Rat {attacker.Name} dealing {spellPower}");
                return spellPower;
            }
        }
    }
}