using System.Collections.Generic;
using System.Linq;

namespace roleplay
{
    public class SpellsBook : IMagicItems
    {
        public int AttackValue
        {
            get { return Spells.Sum(s => s.AttackValue); }
        }

        public int DefenseValue
        {
            get { return Spells.Sum(s => s.DefenseValue); }
        }

        public ICollection<Spell> Spells { get; set; }

        // El constructor recibe una cantidad variable de hechizos con 'params'
        public SpellsBook(params Spell[] spells)
        {
            Spells = new List<Spell>(spells);
        }
    }
}