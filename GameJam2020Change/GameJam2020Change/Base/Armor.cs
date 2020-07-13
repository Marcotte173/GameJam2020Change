using System;
using System.Collections.Generic;
using System.Text;

public class Armor:Item
{
    public int defence;
    public int mitigation;
    public Armor(string name, int mitigation, int defence)
    : base()
    {
        weapon = false;
        this.name = name;
        this.mitigation = mitigation;
        this.defence = defence;
    }
}