using System;
using Defenders;

namespace Enemies
{
    class Ogre : Enemy
    {
        public int Armor { get; }

        public Ogre(string name, int hp, int armor) : base(name, hp)
        {
            Armor = armor;
        }
        public override void Attacked(IDefender defender)
        {
            int damage = defender.Attack(this);
            if (damage > Armor)
                damage -= Armor;
            else if(damage>0)
                damage = 1; //in the .txt it says "but always at least 1 point", not sure if it refers to this
            
            GetDamage(damage); 


        }
    }
}