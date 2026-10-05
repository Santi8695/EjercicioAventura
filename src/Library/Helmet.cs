<<<<<<< HEAD
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
=======
namespace roleplay
{
    public class Helmet : IItem
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Helmet(int attack, int defense)
        {
            this.AttackValue = attack;
            this.DefenseValue = defense;
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        }
    }
}