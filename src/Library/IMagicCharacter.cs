using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Roleplay
{
    public interface IMagicCharacter : ICharacter, IMagicItems, ISpell
    {

        public void AddSpell(ISpell spell)
        {
            return spell;
        }
        public void RemoveSpell(ISpell spell)
        {
            return spell;
        }

        public void AddItem(IMagicItem item)
        {
            return item;
        }

        public void RemoveItem(IMagicItem item)
        {
            return item;
        }
    }
}