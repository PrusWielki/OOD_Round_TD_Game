using System;
using Defenders;

namespace Enemies
{
    class Giant : Enemy
    {

        public Giant(string name, int hp) : base(name, hp)
        {
        }
        public override void Attacked(IDefender defender)
        {
            GetDamage(defender.Attack(this));
        }
    }
}