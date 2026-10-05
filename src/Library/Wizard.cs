using System;
using System.Collections.Generic;
using Roleplay;

namespace roleplay
{
<<<<<<< HEAD
    /// <summary>
    /// Representa a un mago del juego que puede atacar, defenderse y usar objetos.
    /// </summary>
    public class Wizard : IMagicCharacter, ICharacter
=======
    public class Wizard : ICharacter
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
    {
        private readonly List<IItems> items;
        private readonly List<IMagicalItems> magicalItems;

        /// <summary>
        /// Nombre del mago.
        /// </summary>
        public string Name { get; set; }
<<<<<<< HEAD

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
=======
        public IMagicItems FirstItem { get; set; }
        public IMagicItems SecondItem { get; set; }

>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        public int AttackValue
        {
            get { return this.FirstItem.AttackValue + this.SecondItem.AttackValue; }
        }

<<<<<<< HEAD
        // La defensa del mago se calcula sumando la de su bastón y su libro de hechizos
        /// <summary>
        /// Obtiene el valor total de defensa del mago.
        /// </summary>
=======
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        public int DefenseValue
        {
            get { return this.FirstItem.DefenseValue + this.SecondItem.DefenseValue; }
        }

        /// <summary>
        /// Salud actual del mago.
        /// </summary>
        public int Health { get; set; }

<<<<<<< HEAD
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
=======
        public Wizard(string name, IMagicItems firstItem, IMagicItems secondItem)
        {
            this.Name = name;
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.Health = 5;
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        }

        public void RecibeAttack(int attack)
        {
            int danio = attack - this.DefenseValue;
            if (danio < 0)
                danio = 0;
            this.Health -= danio;
        }

        /// <summary>
        /// Restaura la salud del mago al máximo.
        /// </summary>
        public void Cure()
        {
            this.Health = 5;
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