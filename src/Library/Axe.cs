namespace roleplay
{
    public class Axe : IItem
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Axe(int attack, int defense)
        {
            this.AttackValue = attack;
            this.DefenseValue = defense;
        }
    }
}