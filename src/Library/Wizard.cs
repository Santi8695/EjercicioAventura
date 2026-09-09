using System;

namespace MagoRPG
{
    public class Wizard
    {
        public string Name { get; set; }
        public SpellsBook SpellsBook { get; set; }
        public Staff Staff { get; set; }

        // El ataque del mago se calcula sumando el de su bastón y su libro de hechizos
        public int AttackValue
        {
            get
            {
                int ataqueStaff = 0;
                int ataqueLibro = 0;

                if (Staff != null)
                    ataqueStaff = Staff.AttackValue;

                if (SpellsBook != null)
                    ataqueLibro = SpellsBook.AttackValue;

                return ataqueStaff + ataqueLibro;
            }
        }

        // La defensa del mago se calcula sumando la de su bastón y su libro de hechizos
        public int DefenseValue
        {
            get
            {
                int defensaStaff = 0;
                int defensaLibro = 0;

                if (Staff != null)
                    defensaStaff = Staff.DefenseValue;

                if (SpellsBook != null)
                    defensaLibro = SpellsBook.DefenseValue;

                return defensaStaff + defensaLibro;
            }
        }

        public int Health { get; set; }

        private const int MaxHealth = 5;

        public Wizard(string name)
        {
            Name = name;
            Health = MaxHealth;

            // Según el diagrama, el Mago "has" un libro y un bastón,
            // así que se inicializan al crear al mago
            SpellsBook = new SpellsBook();
            Staff = new Staff(5, 5); // valores base de ejemplo
        }

        public void ReceiveAttack(int power)
        {
            // El daño real es el poder del ataque menos la defensa del mago
            int actualDamage = power - DefenseValue;

            if (actualDamage > 0)
            {
                Health -= actualDamage;
            }

            if (Health < 0)
            {
                Health = 0;
            }
        }

        public void Cure()
        {
            // Restaura la salud del mago al máximo
            Health = MaxHealth;
            Console.WriteLine($"{Name} se ha curado completamente.");
        }
    }
}