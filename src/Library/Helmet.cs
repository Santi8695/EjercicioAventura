namespace Roleplay
{
    public class Helmet : IDefenseItem
    {
        public string Name { get; private set; }

        public int DefenseValue { get; private set; }

        public Helmet(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}