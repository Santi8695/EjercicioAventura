namespace Roleplay
{
    public class Knight : ICharacter
    {
        public Knight(string name, IItem firstItem, IItem secondItem, IItem thirdItem) : base(name, 20)
        {
            this.AddItem(firstItem);
            this.AddItem(secondItem);
            this.AddItem(thirdItem);
        }
    }
}