namespace Roleplay
{    
    public class Axe: IItem
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
        }
    }
}