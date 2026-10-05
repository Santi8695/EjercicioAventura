namespace roleplay
{
    public class Spell : IMagicItems
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Spell(int attack, int defense)
        {
            this.AttackValue = attack;
            this.DefenseValue = defense;
        }
    }
}