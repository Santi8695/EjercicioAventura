using System;
namespace roleplay
{

    public class Dwarf : ICharacter
    {
        public string Name { get; set; }
        public IItem FirstItem { get; set; }
        public IItem SecondItem { get; set; }
        public IItem ThirdItem { get; set; }
        public int AttackValue { get { return this.FirstItem.AttackValue + this.SecondItem.AttackValue + this.ThirdItem.AttackValue; } }
        public int DefenseValue { get { return this.FirstItem.DefenseValue + this.SecondItem.DefenseValue + this.ThirdItem.DefenseValue; } }
        public int Health { get; set; }

        public Dwarf(string name, IItem firstItem, IItem secondItem, IItem thirdItem)
        {
            this.Name = name;
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
            this.Health = 8;
        }


        public void RecibeAttack(int attack)
        {
            int danio = attack - this.DefenseValue;
            if (danio < 0)
                danio = 0;
            this.Health -= danio;
        }

        public void Cure()
        {
            this.Health = 20;
        }
    }
}