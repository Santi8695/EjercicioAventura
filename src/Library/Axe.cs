namespace Roleplay
{
    public class Axe : IAttackItem
    {
        public string Name { get; private set; }

        public int AttackValue { get; private set; }

        public Axe(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}