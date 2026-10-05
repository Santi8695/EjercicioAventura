<<<<<<< HEAD
namespace Roleplay
{    
    public class Axe: IAttackItem, IItems
    {
        public string Name = "Leviatán";
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
        public Axe(string name, int attackValue, int DefenseValue)
        {
            this.AttackValue = CalculateDefense();
            this.DefenseValue = CalculateAttack();
            this.Name = name;
=======
namespace roleplay
{
    public class Axe : IItem
    {
        public int AttackValue { get; }
        public int DefenseValue { get; }

        public Axe(int attack, int defense)
        {
            this.AttackValue = attack;
            this.DefenseValue = defense;
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        }
    }
}