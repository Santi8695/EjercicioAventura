namespace Roleplay
{
    public class Sword : IAttackItem
    {
        public string Name { get; private set; }

        public int AttackValue { get; private set; }

        public Sword(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}