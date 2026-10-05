public abstract class ICharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    public ICharacter(string name)
    {
        Name = name;
        Health = 100;
    }

    public abstract int AttackValue { get; }
    public abstract int DefenseValue { get; }

    public abstract void AddItem(IItem item);
    public abstract void RemoveItem(IItem item);

    public virtual void Cure()
    {
        Health = 100;
    }

    public virtual void ReceiveAttack(int power)
    {
        Health -= power;
    }
}