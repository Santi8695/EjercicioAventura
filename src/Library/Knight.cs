using System;

public class Knight : ICharacter
{
    public string Name { get; set; }
    public IItem FirstItem { get; set; }
    public IItem SecondItem { get; set; }
    public IItem ThirdItem { get; set; }
    public int AttackValue { get; set; }
    public int DeffenseValue { get; set; }
    public int Health { get; set; }

    public Knight(string name, Sword sword, Shield shield, Armor armor)
    {
        this.Name = name;
        this.FirstItem = sword;
        this.SecondItem = shield;
        this.ThirdItem = armor;
        this.Health = 20;
        this.AttackValue = CalculateAttack();
        this.DeffenseValue = CalculateDefense();
    }

    public int CalculateAttack()
    {
        return this.FirstItem.AttackValue + this.SecondItem.AttackValue + this.ThirdItem.AttackValue;
    }

    public void RecibeAttack(int attack)
    {
        int danio = attack - this.DeffenseValue;
        if (danio < 0)
            danio = 0;
        this.Health -= danio;
        Console.WriteLine($"{this.Name} ha sufrido {danio} de daño, quedo a {this.Health}");
    }

    public int CalculateDefense()
    {
        return this.FirstItem.DefenseValue + this.SecondItem.DefenseValue + this.ThirdItem.DefenseValue;
    }

    public void Cure()
    {
        this.Health = 20;
    }
}