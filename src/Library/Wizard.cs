using System;
using System.Collections.Generic;
using Roleplay;

namespace MagoRPG
{
    /// <summary>
    /// Representa a un mago del juego que puede atacar, defenderse y usar objetos.
    /// </summary>
    public class Wizard : IMagicCharacter, ICharacter
    {
        private readonly List<IItems> items;
        private readonly List<IMagicalItems> magicalItems;

        /// <summary>
        /// Nombre del mago.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Libro de hechizos que usa el mago.
        /// </summary>
        public SpellsBook SpellsBook { get; set; }

        /// <summary>
        /// Bastón del mago.
        /// </summary>
        public Staff Staff { get; set; }

        // El ataque del mago se calcula sumando el de su bastón y su libro de hechizos
        /// <summary>
        /// Obtiene el valor total de ataque del mago.
        /// </summary>
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
        /// <summary>
        /// Obtiene el valor total de defensa del mago.
        /// </summary>
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

        /// <summary>
        /// Salud actual del mago.
        /// </summary>
        public int Health { get; set; }

        private const int MaxHealth = 5;

        /// <summary>
        /// Inicializa un nuevo mago.
        /// </summary>
        /// <param name="name">Nombre del mago.</param>
        public Wizard(string name) : base()
        {
            Name = name;
            Health = MaxHealth;

            SpellsBook = new SpellsBook();
            Staff = new Staff(5, 5); // valores base de ejemplo
            items = new List<IItems>();
            magicalItems = new List<IMagicalItems>();
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

        /// <summary>
        /// Restaura la salud del mago al máximo.
        /// </summary>
        public void Cure()
        {
            // Restaura la salud del mago al máximo
            Health = MaxHealth;
            Console.WriteLine($"{Name} se ha curado completamente.");
        }

        /// <summary>
        /// Agrega un ítem no mágico al inventario del mago.
        /// </summary>
        /// <param name="item">Ítem a agregar.</param>
        public void AddItem(IItems item)
        {
            if (item == null)
            {
                return;
            }

            if (!this.items.Contains(item))
            {
                this.items.Add(item);
            }
        }

        public void RemoveItem(IItems item)
        {
            if (item == null)
            {
                return;
            }

            this.items.Remove(item);
        }

        public void AddItem(IMagicalItems item)
        {
            if (item == null)
            {
                return;
            }

            if (!this.magicalItems.Contains(item))
            {
                this.magicalItems.Add(item);
            }
        }

        public void RemoveItem(IMagicalItems item)
        {
            if (item == null)
            {
                return;
            }

            this.magicalItems.Remove(item);
        }
    }
}