using System.Collections.Generic;

namespace Roleplay
{
    /// <summary>
    /// Representa a un mago del juego que puede atacar, defenderse y usar objetos.
    /// </summary>
    public class Wizard : ICharacter, IMagicCharacter
    {
        private readonly List<IMagicalItem> magicalItems = new List<IMagicalItem>();
        private readonly SpellsBook spellsBook = new SpellsBook();

        /// <summary>
        /// Inicializa un nuevo mago. Su libro de hechizos cuenta como item mágico.
        /// </summary>
        /// <param name="name">Nombre del mago.</param>
        public Wizard(string name) : base(name)
        {
            this.magicalItems.Add(this.spellsBook);
        }

        // Ataque de los items comunes (ICharacter) + ataque de los items mágicos
        public override int AttackValue
        {
            get
            {
                int total = base.AttackValue;
                foreach (IMagicalItem magicalItem in this.magicalItems)
                {
                    IMagicalAttackItem magicalAttackItem = magicalItem as IMagicalAttackItem;
                    if (magicalAttackItem != null)
                    {
                        total += magicalAttackItem.AttackValue;
                    }
                }
                return total;
            }
        }

        // Defensa de los items comunes (ICharacter) + defensa de los items mágicos
        public override int DefenseValue
        {
            get
            {
                int total = base.DefenseValue;
                foreach (IMagicalItem magicalItem in this.magicalItems)
                {
                    IMagicalDefenseItem magicalDefenseItem = magicalItem as IMagicalDefenseItem;
                    if (magicalDefenseItem != null)
                    {
                        total += magicalDefenseItem.DefenseValue;
                    }
                }
                return total;
            }
        }

        public void AddItem(IMagicalItem item)
        {
            if (item != null && !this.magicalItems.Contains(item))
            {
                this.magicalItems.Add(item);
            }
        }

        public void RemoveItem(IMagicalItem item)
        {
            if (item != null)
            {
                this.magicalItems.Remove(item);
            }
        }

        public void AddSpell(ISpell spell)
        {
            this.spellsBook.AddSpell(spell);
        }

        public void RemoveSpell(ISpell spell)
        {
            this.spellsBook.RemoveSpell(spell);
        }
    }
}