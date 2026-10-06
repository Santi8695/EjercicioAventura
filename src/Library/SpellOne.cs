namespace Roleplay
{
    public class SpellOne : ISpell
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public SpellOne(int attackValue, int defenseValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    }
}