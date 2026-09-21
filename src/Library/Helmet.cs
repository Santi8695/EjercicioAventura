public class Helmet : IItem
{
    public int AttackValue { get; }
    public int DefenseValue { get; }

    public Helmet(int attack, int defense)
    {
        this.AttackValue = attack;
        this.DefenseValue = defense;
    }
}