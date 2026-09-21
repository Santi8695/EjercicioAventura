using System;

namespace roleplay
{
    public class Wizard : ICharacter
    {
        public string Name { get; set; }
        public IMagicItems FirstItem { get; set; }
        public IMagicItems SecondItem { get; set; }

        public int AttackValue
        {
            get { return this.FirstItem.AttackValue + this.SecondItem.AttackValue; }
        }

        public int DefenseValue
        {
            get { return this.FirstItem.DefenseValue + this.SecondItem.DefenseValue; }
        }

        public int Health { get; set; }

        public Wizard(string name, IMagicItems firstItem, IMagicItems secondItem)
        {
            this.Name = name;
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.Health = 5;
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
            this.Health = 5;
        }
    }
}