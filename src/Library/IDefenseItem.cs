using System.ComponentModel;

namespace RolePlayGame;
public interface IDefenseItem : IRaiseItemChangedEvents
{
    int DefenseValue {get;}
}