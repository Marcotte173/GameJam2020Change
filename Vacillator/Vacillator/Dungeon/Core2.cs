using System;
using System.Collections.Generic;
using System.Text;

public class Core2 : Room
{
    public Core2()
    {
        flavor = "CORE 2";

        visitedFlavor = "NOT YET";
        name = "CORE 2";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(0, 10, flavor);
        Write.KeyPress();

    }
}