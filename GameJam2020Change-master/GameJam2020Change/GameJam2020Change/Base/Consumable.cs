using System;
using System.Collections.Generic;
using System.Text;

public class Consumable : Item
{
    public int heal;
    public int buff;

    public Consumable(string name, int heal, int buff, int value)
    : base()
    {
        consumable = false;
        this.name = name;
        this.heal = heal;
        this.buff = buff;
        this.value = value;
    }
}
