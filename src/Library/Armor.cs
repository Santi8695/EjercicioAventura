namespace Roleplay
{
    public class Armor : IDefenseItem
    {
        public string Name { get; private set; }

        public int DefenseValue { get; private set; }

        public Armor(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}