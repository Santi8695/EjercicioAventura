namespace Roleplay
{
    public class Bow : IAttackItem
    {
        public string Name { get; private set; }

        public int AttackValue { get; private set; }

        public Bow(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}