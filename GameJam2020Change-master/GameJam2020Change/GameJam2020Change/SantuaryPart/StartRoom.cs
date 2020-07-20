using System;

internal class StartRoom : Room
{
    public StartRoom()
    {
        visitedFlavor = "You are at the entrance";
        flavor = "This is where you can insert the cool opening flavor";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(0, 10, flavor);
        Write.KeyPress();
        visited = true;
    }
}