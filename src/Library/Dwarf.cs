using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

public class Dwarf : ICharacter
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
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int CalculateAttack()
    {
        return this.Axe.AttackValue;
    }

    public int CalculateDefense()
    {
        return this.Helmet.DefenseValue + this.Shield.DefenseValue;
    }
    public Dwarf(string name, Axe axe, Helmet helmet, Shield shield)
    {
        this.Name = name;
        this.Health = 8;
        this.Axe = axe;
        this.Helmet = helmet;
        this.Shield = shield;
        this.AttackValue = CalculateAttack();
        this.DefenseValue = CalculateDefense();
    }
    public void RecibeAttack(int attack)
    {
        int danio = attack - this.DefenseValue;
        if(danio<0)
            danio=0;
        this.Health -= danio;
        Console.WriteLine($"{this.Name} ha sufrido {danio} de daño, quedo a {this.Health}");
    }
}
