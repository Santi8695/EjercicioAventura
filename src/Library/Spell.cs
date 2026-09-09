public class Spell
{
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }

    public Spell(int attack, int defense)
    {
        AttackValue = attack;
        DefenseValue = defense;
    }
}