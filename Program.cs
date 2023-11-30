using System;
namespace _vning_objektorientering;


class Program{
    static void Main(string[] args)
{
    Paladin paladin= new Paladin(20, "paladin", 100);
    Sorcerer sorcerer= new Sorcerer(20, "sorcerer", 500);
    Barbarian barbarian= new Barbarian(20, "barbarian", 1000);

    barbarian.Print();
    Console.WriteLine("");
    sorcerer.Print();
    Console.WriteLine("");
    paladin.Print();
}

}
