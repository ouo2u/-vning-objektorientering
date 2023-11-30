using System;
namespace _vning_objektorientering
{

public abstract class Character {
    private string namn;
    private int hp;

    public Character(string namn, int hp)
    {
        this.namn = namn;
        this.hp = hp;
    }

    public string Name {get{return namn;} set{namn=value;}}

    public int Hp {get{return hp;} set{hp=value;}}


public abstract void Print();


}

public class Barbarian : Character
{
    int Ragelevel;

    public Barbarian(int Ragelevel, string name, int hp) : base("Barbarian", 2)
    {
        this.Ragelevel=Ragelevel;
    }

    public override void Print()
    {
       Console.WriteLine($"Ragelevel: {Ragelevel}");
       Console.WriteLine($"type: {Name}");
       Console.WriteLine($"hp: {Hp}");
    }
}

public class Paladin : Character
{
   

    int holypower;

    public Paladin(int holypower, string name, int hp): base("paladin",100){
        this.holypower=holypower;
    }

    public override void Print()
    {
        Console.WriteLine($"holypower: {holypower}");
       Console.WriteLine($"type: {Name}");
       Console.WriteLine($"hp: {Hp}");
    }
}

public class Sorcerer : Character
{

    int Mana= 500;

    public Sorcerer(int Mana, string name, int hp) : base("Sorcerer", 500)
    {
        this.Mana=Mana;
    }

    public override void Print()
    {
       Console.WriteLine($"Mana: {Mana}");
       Console.WriteLine($"type: {Name}");
       Console.WriteLine($"hp: {Hp}");
    }
}

}