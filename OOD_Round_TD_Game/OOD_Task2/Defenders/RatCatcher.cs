using System;
using Enemies;

namespace Defenders
{
    class RatCatcher : IDefender
    {
        protected readonly string name;
        private bool hasRat;

        //string IDefender.name { get { return name; } }
        public RatCatcher(string name)
        {
            this.name = name;
            hasRat=false;
        }
        int IDefender.Attack(Ogre attacker)
        {
            if (hasRat)
            {
                Console.WriteLine($"RatCatcher {name} scares an Ogre {attacker.Name} away with a Rat");
                hasRat = false;
                return attacker.HP+attacker.Armor;
            }
            else
            {
                Console.WriteLine($"RatCatcher {name} stumbles upon an Ogre {attacker.Name} but there is no rat to throw");
                return 0;
            }

        }
        int IDefender.Attack(Giant attacker)
        {
            if (hasRat)
            {
                Console.WriteLine($"RatCatcher {name} stumbles upon a Giant {attacker.Name} but he has a rat so he ignores him");
                return 0;
            }
            Console.WriteLine($"RatCatcher {name} stumbles upon a Giant {attacker.Name} and lets him pass");
            return 0; //not sure what should happen here

        }
        int IDefender.Attack(Rat attacker)
        {
            if (hasRat)
            {
                Console.WriteLine($"RatCatcher {name} stumbles upon a Rat {attacker.Name} but he has one already so he ignores him");
                return 0;
            }
            else
            {
                Console.WriteLine($"RatCatcher {name} catches a Rat {attacker.Name}");
                hasRat = true;
                return attacker.HP;

            }

        }
    }
}