namespace roleplay
{
    public class Staff : IMagicItems
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