<<<<<<< HEAD
using System;
namespace Roleplay
{
public class Staff : IAttackItem, IItems
{
    public int AttackValue {get;}
    public int DefenseValue {get;}

    public int CalculateAttack()
    {
        return this.AttackValue;
    }
    public int CalculateDefense()
    {
        return this.DefenseValue;
    }
    public Staff(int attack, int defense)
=======
namespace roleplay
{
    public class Staff : IMagicItems
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Staff(int attack, int defense)
        {
            this.AttackValue = attack;
            this.DefenseValue = defense;
        }
    }
}
}