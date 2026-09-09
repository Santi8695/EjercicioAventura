public class Knight
{
    public string Name{get;set;}
    public Sword Sword{get;set;}
    public Shield Shield{get;set;}
    public Armor Armor{get;set;}
    public int AttackValue{get;set;}
    public int DeffenseValue{get;set;}
    public int Healt{get;set;}

    public Knight(string name)
    {
        this.Name=name;
    }
}