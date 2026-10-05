namespace Roleplay
{
    public class Helmet : IItems
    {
        public string Name{get; set;}
        public int AttackValue{ get; set;}
        public int DefenseValue{get; set;}
        public int CalculateAttack()
        {
            return this.AttackValue;
        }
        public int CalculateDefense()
        {
            return this.DefenseValue;
        }
        public Helmet(string name, int attackValue, int DefenseValue)
        {
            this.AttackValue = CalculateDefense();
            this.DefenseValue = CalculateAttack();
            this.Name = name;
        }
    }
}