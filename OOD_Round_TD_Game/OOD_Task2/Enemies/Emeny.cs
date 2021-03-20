using System;
using Defenders;

namespace Enemies
{
    abstract class Enemy
    {
        public string Name { get; }

        public bool Alive { get; private set; }
        public int HP { get; private set; }

        protected Enemy(string name, int hp)
        {
            Name = name;
            HP = hp;
            Alive = true;
        }

        abstract public void Attacked(IDefender defender);
            
        
        protected void GetDamage(int damage)
        {
            HP -= damage;
            if(HP<=0)
            {
                Console.WriteLine($"{Name} is dead...");
                Alive = false;
            }
        }

    }
}