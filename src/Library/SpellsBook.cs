using System.Collections.Generic;

namespace Roleplay
{
    public class SpellsBook : IMagicalAttackItem, IMagicalDefenseItem
    {
        private readonly List<ISpell> spells;

        // Recibe una cantidad variable de hechizos con 'params'
        public SpellsBook(params ISpell[] spells)
        {
            this.spells = new List<ISpell>(spells);
        }

        public int AttackValue
        {
            get
            {
                int total = 0;
                foreach (ISpell spell in this.spells)
                {
                    total += spell.AttackValue;
                }
                return total;
            }
        }

        public int DefenseValue
        {
            get
            {
                int total = 0;
                foreach (ISpell spell in this.spells)
                {
                    total += spell.DefenseValue;
                }
                return total;
            }
        }

        public void AddSpell(ISpell spell)
        {
            if (spell != null && !this.spells.Contains(spell))
            {
                this.spells.Add(spell);
            }
        }

        public void RemoveSpell(ISpell spell)
        {
            if (spell != null)
            {
                this.spells.Remove(spell);
            }
        }
    }
}