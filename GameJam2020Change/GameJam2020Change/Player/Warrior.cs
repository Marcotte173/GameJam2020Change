using System;
using System.Collections.Generic;
using System.Text;

public class Warrior:Player
{ 
    public Warrior()
    : base()
    {
        typeName = "Warrior";
        maxHp = hp += 30;
        energy = maxEnergy +=2;
        damage +=2;
        mitigation +=2;
        hit += 5;
        crit += 5;
        defence += 10;
    }
}