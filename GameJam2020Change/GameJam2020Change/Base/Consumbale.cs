using System;
using System.Collections.Generic;
using System.Text;

public class Consumable : Item
{
    public int heal;
    public int buff;

    public Weapon(string name, int heal, int buff)
    : base()
    {
        this.name = name;
        this.heal = heal;
        this.buff = buff;
        consumable = true;
    }
}