using System;
namespace Roleplay
public class Staff : IMagicItems
{
    public int AttackValue {get;}
    public int DefenseValue {get;}

    public Staff(int attack, int defense)
    {
        AttackValue = attack;
        DefenseValue = defense;
    }
}