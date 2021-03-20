using Enemies;

namespace Defenders
{
    interface IDefender
    {
        //public string name { get; }
        int Attack(Ogre attacker);
        int Attack(Giant attacker);
        int Attack(Rat attacker);
    }
}