namespace Roleplay
{
    public class Shield : IDefenseItem
    {
        public string Name { get; private set; }

        public int DefenseValue { get; private set; }

        public Shield(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}