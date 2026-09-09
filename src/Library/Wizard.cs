using System;

public class Wizard
{
    public string Name { get; set; }
    public SpellsBook SpellsBook { get; set; }
    public Staff Staff { get; set; }
    
    // El ataque del mago se basa en su bastón y su libro de hechizos
    public int AttackValue 
    { 
        get { return (Staff?.AttackValue ?? 0) + (SpellsBook?.AttackValue ?? 0); } 
    }
    
    // La defensa del mago se basa en su bastón y su libro de hechizos
    public int DefenseValue 
    { 
        get { return (Staff?.DefenseValue ?? 0) + (SpellsBook?.DefenseValue ?? 0); } 
    }
    
    public int Health { get; set; }
    
    private const int MaxHealth = 100; // Propiedad auxiliar lógica

    public Wizard(string name)
    {
        Name = name;
        Health = MaxHealth;
        
        // Según el diagrama, el Mago *tiene* (has 1) un libro y un bastón, 
        // por lo que se deben inicializar al crear al mago.
        SpellsBook = new SpellsBook();
        Staff = new Staff(5, 5); // Valores base de ejemplo para el bastón
    }

    public void ReceiveAttack(int power)
    {
        // El daño real recibido es el poder del ataque menos la defensa del mago
        int actualDamage = power - DefenseValue;
        
        // Asegurarse de que el daño no sea negativo
        if (actualDamage > 0)
        {
            Health -= actualDamage;
        }

        // Evitar que la salud baje de 0
        if (Health < 0) 
        {
            Health = 0;
        }
    }

    public void Cure()
    {
        // Restaura la salud del mago
        Health = MaxHealth;
        Console.WriteLine($"{Name} se ha curado completamente.");
    }
}