//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace Roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Items base (no magicos, 1 de cada tipo)
            IItem espada = new Sword("Espada", 12);
            IItem hacha = new Axe("Hacha", 10);
            IItem casco = new Helmet("Casco", 2);
            IItem armadura = new Armor("Armadura", 4);
            IItem escudo = new Shield("Escudo", 3);

            //Hechizos para el libro del mago
            ISpell hechizoAtaque = new SpellOne(14, 0);
            ISpell hechizoDefensa = new SpellOne(0, 7);

            //Items base (magicos)
            IMagicalItem libroHechizos = new SpellsBook(hechizoAtaque, hechizoDefensa);
            IItem baston = new Staff(1, 1);

            //Personajes
            ICharacter caballero = new Knight("Clarence", espada, escudo, armadura);
            ICharacter enano = new Dwarf("Brok", espada, escudo, armadura);
            Wizard mago = new Wizard("Gandalf");
            mago.AddItem(libroHechizos);
            mago.AddItem(baston);

            //Atacar y curarse (prueba con caballero)
            caballero.ReceiveAttack(enano.AttackValue);
            Console.WriteLine(caballero.Health);
            caballero.Cure();
            Console.WriteLine(caballero.Health);

            //Atacar y curarse (prueba con enano)
            enano.ReceiveAttack(mago.AttackValue);
            Console.WriteLine(enano.Health);
            enano.Cure();
            Console.WriteLine(enano.Health);

            //Atacar y curarse (prueba con mago)
            mago.ReceiveAttack(caballero.AttackValue);
            Console.WriteLine(mago.Health);
            mago.Cure();
            Console.WriteLine(mago.Health);
        }
    }
}