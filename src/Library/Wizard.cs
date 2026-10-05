using System;

namespace roleplay
{
<<<<<<< HEAD
    public interface IMagicItem
    {
        int CalculateAttack();
        int CalculateDefense();
    }

    public class Wizard : ICharacter
    {
        public string Name { get; set; }
        public IMagicItem FirstMagicItem { get; set; }
        public IMagicItem SecondMagicItem { get; set; }
=======
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

>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        public int Health { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }

<<<<<<< HEAD
        private const int MaxHealth = 5;

        public Wizard(string name, IMagicItem firstMagicItem, IMagicItem secondMagicItem)
        {
            Name = name;
            Health = MaxHealth;
            FirstMagicItem = firstMagicItem;
            SecondMagicItem = secondMagicItem;

            AttackValue = CalcularAtaqueTotal();
            DefenseValue = CalcularDefensaTotal();
        }

        // Recorre los items mágicos del mago y suma su valor de ataque
        private int CalcularAtaqueTotal()
        {
            int total = 0;
            IMagicItem[] items = { FirstMagicItem, SecondMagicItem };

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    total += items[i].CalculateAttack();
                }
            }

            return total;
        }

        // Recorre los items mágicos del mago y suma su valor de defensa
        private int CalcularDefensaTotal()
        {
            int total = 0;
            IMagicItem[] items = { FirstMagicItem, SecondMagicItem };

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    total += items[i].CalculateDefense();
                }
            }

            return total;
        }

        // Cambia o agrega un item mágico; ocupa el primer slot libre
        public void EquipItem(IMagicItem item)
        {
            if (FirstMagicItem == null)
            {
                FirstMagicItem = item;
            }
            else
            {
                SecondMagicItem = item;
            }

            // AttackValue/DefenseValue son campos, no se recalculan solos:
            // hay que actualizarlos a mano cada vez que cambia un item
            AttackValue = CalcularAtaqueTotal();
            DefenseValue = CalcularDefensaTotal();
=======
        public Wizard(string name, IMagicItems firstItem, IMagicItems secondItem)
        {
            this.Name = name;
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.Health = 5;
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
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