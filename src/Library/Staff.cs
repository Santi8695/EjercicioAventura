public class Staff
{
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }

    public Staff(int attack, int defense)
    {
        AttackValue = attack;
        DefenseValue = defense;
    }
}