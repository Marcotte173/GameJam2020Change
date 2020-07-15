using System;
using System.Collections.Generic;
using System.Text;

public class Mage:Player
{ 
    public Mage()
    : base()
    {
        typeName = "Mage";
        maxHp = hp += 15;
        energy = maxEnergy +=10;
        damage +=2;
        hit += 5;
        crit += 5;
        defence += 3;
    }
}