namespace roleplay
{
    public interface ICharacter
    {
        int AttackValue { get; }
        int DefenseValue { get; }
        int Health { get; } 
        void RecibeAttack(int attack);
        void Cure();
    }
}