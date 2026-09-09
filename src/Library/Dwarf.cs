public class Dwarf
{
    private string name;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Axe axe { get; set; }
    public Shield shield { get; set; }
    public Helmet helmet { get; set; }

    public int AttackValue
    {
        get
        {
            int attack = 0;
            if (this.axe != null)
            {
                attack += this.axe.AttackValue;
            }
            return attack;
        }
    }

    public int DefenseValue
    {
        get
        {
            int defense = 0;
            if (this.shield != null) defense += this.shield.DefenseValue;
            if (this.helmet != null) defense += this.helmet.DefenseValue;
            return defense;
        }
    }

    public int Health = 10;
}
