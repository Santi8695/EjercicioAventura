namespace Roleplay
{
    public class Archer : ICharacter
    {
        public Archer(string name, IItem firstItem, IItem secondItem, IItem thirdItem) : base(name, 8)
        {
            this.AddItem(firstItem);
            this.AddItem(secondItem);
            this.AddItem(thirdItem);
        }
    }
}