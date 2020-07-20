using System;
using System.Collections.Generic;
using System.Text;

public class Weapon : Item
{
    public int damage;
    public int crit;
    public int hit;

    public Weapon(string name, int damage, int hit, int crit, int value)
    : base()
    {
        this.name = name;
        this.damage = damage;
        this.hit = hit;
        this.crit = crit;
        weapon = true;
        this.value = value;
    }
}