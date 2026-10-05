namespace roleplay
{
    public class Armor : IItem
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Armor(int attack, int defense)
        {
            this.AttackValue = attack;
            this.DefenseValue = defense;
        }
    }
}