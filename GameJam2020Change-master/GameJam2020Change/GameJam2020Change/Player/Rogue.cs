using System;
using System.Collections.Generic;
using System.Text;

public class Rogue:Player
{ 
    public Rogue()
    : base()
    {
        typeName = "Rogue";
        maxHp = hp += 20;
        energy = maxEnergy +=4;
        damage +=4;
        mitigation +=1;
        hit += 10;
        crit += 10;
        defence += 5;
    }
}