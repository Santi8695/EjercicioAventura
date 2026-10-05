//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;

namespace roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //Items base (no magicos, 1 de cada tipo)
            IItem espada = new Sword(12, 1);
            IItem hacha = new Axe(10, 1);
            IItem casco = new Helmet(1, 2);
            IItem armadura = new Armor(1, 4);
            IItem escudo = new Shield(1, 3);

            //Hechizos para el libro del mago
            Spell hechizoAtaque = new Spell(14, 0);
            Spell hechizoDefensa = new Spell(0, 7);

            //Items base (magicos)
            IMagicItems libroHechizos = new SpellsBook(hechizoAtaque, hechizoDefensa);
            IMagicItems baston = new Staff(1, 1);


            //Personajes
            ICharacter caballero = new Knight("Clarence", espada, escudo, armadura);
            ICharacter enano = new Dwarf("Brok", espada, escudo, armadura);
            ICharacter mago = new Wizard("Gandalf", libroHechizos, baston);

            //Atacar y curarse (prueba con caballero)
            caballero.RecibeAttack(enano.AttackValue);
            Console.WriteLine(caballero.Health);
            caballero.Cure();
            Console.WriteLine(caballero.Health);

            //Atacar y curarse (prueba con enano)
            enano.RecibeAttack(mago.AttackValue);
            Console.WriteLine(enano.Health);
            enano.Cure();
            Console.WriteLine(enano.Health);

            //Atacar y curarse (prueba con mago)
            mago.RecibeAttack(caballero.AttackValue);
            Console.WriteLine(mago.Health);
            mago.Cure();
            Console.WriteLine(mago.Health);

        }
    }
}