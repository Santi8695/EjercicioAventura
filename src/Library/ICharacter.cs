using System.Collections.Generic;

namespace Roleplay
{
    public abstract class ICharacter
    {
        private readonly int maxHealth;
        private readonly List<IItem> items = new List<IItem>();

        public string Name { get; set; }
        public int Health { get; set; }

        public ICharacter(string name) : this(name, 100)
        {
        }

        protected ICharacter(string name, int maxHealth)
        {
            this.Name = name;
            this.maxHealth = maxHealth;
            this.Health = maxHealth;
        }

        // Suma del ataque de todos los items de ataque equipados
        public virtual int AttackValue
        {
            get
            {
                int total = 0;
                foreach (IItem item in this.items)
                {
                    IAttackItem attackItem = item as IAttackItem;
                    if (attackItem != null)
                    {
                        total += attackItem.AttackValue;
                    }
                }
                return total;
            }
        }

        // Suma de la defensa de todos los items de defensa equipados
        public virtual int DefenseValue
        {
            get
            {
                int total = 0;
                foreach (IItem item in this.items)
                {
                    IDefenseItem defenseItem = item as IDefenseItem;
                    if (defenseItem != null)
                    {
                        total += defenseItem.DefenseValue;
                    }
                }
                return total;
            }
        }

        public virtual void AddItem(IItem item)
        {
            if (item != null && !this.items.Contains(item))
            {
                this.items.Add(item);
            }
        }

        public virtual void RemoveItem(IItem item)
        {
            if (item != null)
            {
                this.items.Remove(item);
            }
        }

        public virtual void Cure()
        {
            this.Health = this.maxHealth;
        }

        public virtual void ReceiveAttack(int power)
        {
            int damage = power - this.DefenseValue;
            if (damage < 0)
            {
                damage = 0;
            }

            this.Health -= damage;
        }
    }
}