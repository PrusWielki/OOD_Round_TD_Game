using System;
using Defenders;

namespace Enemies
{
    class Rat : Enemy
    {
        public int Speed { get; private set; } //private set allowed by Piotr Wolszakiewicz, speed needs to be changed so I guess it should be here

        public Rat(string name, int hp, int speed) : base(name, hp)
        {
            Speed = speed;
        }
        public override void Attacked(IDefender defender)
        {
            GetDamage(defender.Attack(this));
            Speed += 1;

        }
    }
}