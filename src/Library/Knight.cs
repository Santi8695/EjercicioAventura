using System;

public class Knight : IAttack, IDefense, ICure
{
    public string Name { get; set; }
    public Sword Sword { get; set; }
    public Shield Shield { get; set; }
    public Armor Armor { get; set; }
    public int AttackValue { get; set; }
    public int DeffenseValue { get; set; }
    public int Health { get; set; }

    public Knight(string name, Sword sword, Shield shield, Armor armor)
    {
        this.Name = name;
        this.Sword = sword;
        this.Shield = shield;
        this.Armor = armor;
        this.Health = 20;
        this.AttackValue = CalculateAttack();
        this.DeffenseValue = CalculateDefense();
    }

    public int CalculateAttack()
    {
        return this.Sword.AttackValue;
    }

    public void RecibeAttack(int attack)
    {
        int danio = attack - this.DeffenseValue;
        if(danio<0)
            danio=0;
        this.Health -= danio;
        Console.WriteLine($"{this.Name} ha sufrido {danio} de daño, quedo a {this.Health}");
    }

    public int CalculateDefense()
    {
        return this.Shield.DefenseValue + this.Armor.DefenseValue;
    }

    public void Cure()
    {
        this.Health=20;
    }
}