using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;
       // string IDefender.name { get { return name; } }
        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }

            Console.WriteLine($"Mage {name} is recharging mana");
            RechargeMana();
            return false;
        }

       public virtual int Attack(Ogre attacker)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"Mage {name} attacks an Ogre {attacker.Name} dealing {spellPower}");
                return spellPower;


            }
            else
            {
                //There is a notfication in CanCastSpell already so I guess these are redundant
                // Console.WriteLine($"Mage {name} has too little mana to attack an Ogre {attacker.Name}");
                return 0;
            }

            
        }
        public virtual int Attack(Rat attacker)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"Mage {name} attacks a Rat {attacker.Name} dealing {spellPower}");
                return spellPower;


            }
            else
            {
                
               // Console.WriteLine($"Mage {name} has too little mana to attack a Rat {attacker.Name}");
                return 0;
            }


        }
        public virtual int Attack(Giant attacker)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"Mage {name} attacks a Giant {attacker.Name} dealing {spellPower}");
                return spellPower;


            }
            else
            {
               // Console.WriteLine($"Mage has too little mana to attack a Giant {attacker.Name}");
                return 0;
            }


        }
        private void RechargeMana()
        {
            mana += manaRegen;
        }
    }
}