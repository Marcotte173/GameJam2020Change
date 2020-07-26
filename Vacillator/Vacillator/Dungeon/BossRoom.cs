using System;
using System.Collections.Generic;
using System.Text;

public class BossRoom : Room
{
    public BossRoom()
    {
        flavor = "Boss Flavor. Spence, get to";

        visitedFlavor = "NOT YET";
        name = "Boss Room";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        Write.Line(0, 10, flavor);
        if (Manager.coreVisited > 2)
        {
            MonsterCreate m = Monsters.orcs[1];
            m.name = "Savage Orc";
            m.summon = "A Savage Orc";
            Monsters.Summon(m);
            Write.Line($"SPENCER, WRITE SOME COOL FLAVOR ABOUT {m.summon}");
            Write.KeyPress(0, 28);
            Combat.boss = true;
            Combat.Start();
        }
        else
        {
            Write.Line("There is more to do in this dungeon. Come back when you have explored more");
            Write.KeyPress();
        }
        Console.Clear();        
    }    
}