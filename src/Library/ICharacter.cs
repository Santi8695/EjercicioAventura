<<<<<<< HEAD
namespace Roleplay
{
    public interface ICharacter
    {
        void RecibeAttack(int attack);

=======
namespace roleplay
{
    public interface ICharacter
    {
        int AttackValue { get; }
        int DefenseValue { get; }
        int Health { get; } 
        void RecibeAttack(int attack);
>>>>>>> 9eaba7515e6445d3abfd47fbaf32358efafc0deb
        void Cure();
    }
}