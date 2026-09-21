public class Sword : IItem
{
    public int AttackValue { get; }
    public int DefenseValue { get; }

    public Sword(int attack, int defense)
    {
        this.AttackValue = attack;
        this.DefenseValue = defense;
    }
}