using System.Collections.Generic;

namespace RoleplayGame;

/// <summary>
/// Representa a un mago del juego que puede atacar, defenderse y usar objetos.
/// </summary>
public class Wizard : ICharacter, IMagicCharacter
{
    private readonly List<IItem> items = new List<IItem>();
    private readonly List<IMagicalItem> magicalItems = new List<IMagicalItem>();
    private readonly SpellsBook spellsBook = new SpellsBook();

    /// <summary>
    /// Inicializa un nuevo mago. Su libro de hechizos cuenta como item mágico.
    /// </summary>
    /// <param name="name">Nombre del mago.</param>
    public Wizard(string name) : base(name)
    {
        this.magicalItems.Add(this.spellsBook);
    }

    /// <summary>
    /// Valor total de ataque: items comunes de ataque + items mágicos de ataque.
    /// </summary>
    public override int AttackValue
    {
        get
        {
            int total = 0;

            foreach (IItem item in this.items)
            {
                if (item is IAttackItem attackItem)
                {
                    total += attackItem.AttackValue;
                }
            }

            foreach (IMagicalItem magicalItem in this.magicalItems)
            {
                if (magicalItem is IMagicalAttackItem magicalAttackItem)
                {
                    total += magicalAttackItem.AttackValue;
                }
            }

            return total;
        }
    }

    /// <summary>
    /// Valor total de defensa: items comunes de defensa + items mágicos de defensa.
    /// </summary>
    public override int DefenseValue
    {
        get
        {
            int total = 0;

            foreach (IItem item in this.items)
            {
                if (item is IDefenseItem defenseItem)
                {
                    total += defenseItem.DefenseValue;
                }
            }

            foreach (IMagicalItem magicalItem in this.magicalItems)
            {
                if (magicalItem is IMagicalDefenseItem magicalDefenseItem)
                {
                    total += magicalDefenseItem.DefenseValue;
                }
            }

            return total;
        }
    }

    public override void AddItem(IItem item)
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

    public override void RemoveItem(IItem item)
    {
        if (item == null)
        {
            return;
        }

        this.items.Remove(item);
    }

    public void AddItem(IMagicalItem item)
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

    public void RemoveItem(IMagicalItem item)
    {
        if (item == null)
        {
            return;
        }

        this.magicalItems.Remove(item);
    }

    public void AddSpell(ISpell spell)
    {
        this.spellsBook.AddSpell(spell);
    }

    public void RemoveSpell(ISpell spell)
    {
        this.spellsBook.RemoveSpell(spell);
    }
}