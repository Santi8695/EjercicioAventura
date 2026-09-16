using System;
using System.ComponentModel;
using System.Net.Http.Headers;
namespace Roleplay
{
    
    public class Dwarf : ICharacter, IItems
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private int health;
        public int Health{ get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public int CalculateTotalAttack()
        {
            return this.FirstItem.AttackValue + this.SecondItem.AttackValue + this.ThirdItem.AttackValue;
        }

        public int CalculateTotalDefense()
        {
            return this.FirstItem.DefenseValue + this.SecondItem.DefenseValue + this.ThirdItem.DefenseValue;
        }
        public Dwarf(string name, IItem FirstItem, IItem SecondItem, IItem ThirdItem)
        {
            this.Name = name;
            this.Health = 8;
            this.FirstItem = this.EquipItem(FirstItem);
            this.SecondItem = this.EquipItem(SecondItem);
            this.ThirdItem = this.EquipItem(ThirdItem);
            this.AttackValue = CalculateTotalAttack();
            this.DefenseValue = CalculateTotalDefense();
        }
        public void RecibeAttack(int attack)
        {
            int danio = attack - this.DefenseValue;
            if(danio<0)
                danio=0;
            this.Health -= danio;
            Console.WriteLine($"{this.Name} ha sufrido {danio} de daño, quedo a {this.Health}");
        }
        public void Cure()
        {
            this.Health=8;
        }
        public IItems EquipItem(Item item)
        {
            return item;
        }
    }
}