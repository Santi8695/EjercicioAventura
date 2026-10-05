using System;

namespace MagoRPG
{
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
        public int Health { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }

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
        }

        public void ReceiveAttack(int power)
        {
            // El daño real es el poder del ataque menos la defensa del mago
            int actualDamage = power - DefenseValue;

            if (actualDamage > 0)
            {
                Health -= actualDamage;
            }

            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Cure()
        {
            // Restaura la salud del mago al máximo
            Health = MaxHealth;
            Console.WriteLine($"{Name} se ha curado completamente.");
        }
    }
}