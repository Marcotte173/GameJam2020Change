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
        if (visited) Write.Line(visitedFlavor);
        else
        {
            Write.Line(0, 10, flavor);
        }
        Write.KeyPress();
        Console.Clear();        
    }    
}
