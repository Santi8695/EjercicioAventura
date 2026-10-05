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
    {
        AttackValue = attack;
        DefenseValue = defense;
    }
}
}