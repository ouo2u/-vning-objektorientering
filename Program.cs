Console.Write("Hello world");


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

    public Barbarian(int Ragelevel) : base("Ragelevel", 2)
    {
        this.Ragelevel=Ragelevel;
    }

    public override void Print()
    {
        Console.WriteLine(Ragelevel);
    }
}

public class Paladin : Character
{
   

    int holypower;

    public Paladin(int holypower): base("paladin",100){
        this.holypower=holypower;
    }

    public override void Print()
    {
        throw new NotImplementedException();
    }
}

public class Sorcerer : Character
{

    int Mana= 500;

    public Sorcerer(int Mana) : base("Mana", 500)
    {
        this.Mana=Mana;
    }

    public override void Print()
    {
        throw new NotImplementedException();
    }
}
