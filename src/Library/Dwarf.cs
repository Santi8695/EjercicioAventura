using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

public class Dwarf : IRecibeAttack<Dwarf>
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    private int health;
    public int Health
    {
        get { return this.health; }
        set { this.health = value; }
    }

    public Axe Axe{ get; set; }
    public Shield Shield{ get; set; }
    public Helmet Helmet{ get; set; }

    public int AttackValue
    {
        get
        {
            int attack = 0;
            if (this.Axe != null)
            {
                attack += this.Axe.AttackValue;
            }
            return attack;
        }
    }

    public int DefenseValue
    {
        get
        {
            int defense = 0;
            if (this.Shield != null) defense += this.Shield.DefenseValue;
            if (this.Helmet != null) defense += this.Helmet.DefenseValue;
            return defense;
        }
    }
    public Dwarf(string name, Axe axe, Helmet helmet, Shield shield)
    {
        this.Name = name;
        this.Health = 8;
        this.Axe = axe;
        this.Helmet = helmet;
        this.Shield = shield;
    }
    public void RecibeAttack(T attacker)
    {
        int damage = 0;
        damage = attacker.AttackValue 
    }

}
