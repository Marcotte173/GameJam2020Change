using System;
using System.Collections.Generic;
using System.Text;

public class Core3 : Room
{
    public Core3()
    {
        flavor = "CORE 3";

        visitedFlavor = "NOT YET";
        name = "CORE 3";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(0, 10, flavor);
        Write.KeyPress();

    }
}