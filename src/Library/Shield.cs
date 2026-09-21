public class Shield : IItem
{
    public int AttackValue { get; }
    public int DefenseValue { get; }

    public Shield(int attack, int defense)
    {
        this.AttackValue = attack;
        this.DefenseValue = defense;
    }
}