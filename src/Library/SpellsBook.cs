using System.Collections.Generic;
using System.Linq;

public class SpellsBook
{
    public ICollection<Spell> Spells { get; set; }
    
    // El valor de ataque es la suma del ataque de todos los hechizos
    public int AttackValue 
    { 
        get { return Spells.Sum(s => s.AttackValue); } 
    }
    
    // El valor de defensa es la suma de la defensa de todos los hechizos
    public int DefenseValue 
    { 
        get { return Spells.Sum(s => s.DefenseValue); } 
    }

    public SpellsBook()
    {
        Spells = new List<Spell>();
    }
}