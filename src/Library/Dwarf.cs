namespace Roleplay
{
    public class Dwarf : ICharacter
    {
        public Dwarf(string name, IItem firstItem, IItem secondItem, IItem thirdItem) : base(name, 8)
        {
            this.AddItem(firstItem);
            this.AddItem(secondItem);
            this.AddItem(thirdItem);
        }
    }
}