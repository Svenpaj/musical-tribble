using System.Diagnostics.Contracts;

namespace App;

class Item
{
    public string? Name;
    public string? Description;
    public int Attack;


    public Item(string name, string desc, int attack)
    {
        Name = name;
        Description = desc;
        Attack = attack;
    }
}

