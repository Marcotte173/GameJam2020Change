using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Loot : Room

{
    



    public Loot()
    {
        flavor = " ";

        visitedFlavor = "once again just leave";
        name = "Room with stuff in it";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(0, 10, flavor);
        Write.KeyPress();
        Interact();

    }


    public void Interact()
    {
        Console.Clear();
        if (!visited)
        {
            Write.Line(10,10,"You enter a room with two pedistals,");
            Write.Line(10, 11, "one with a sword that hums with overwhelming streangth");
            Write.Line(10, 12, "and the other with an orb that calls out with knowledge and power.");

            Write.Line(75, 18, "[T]ake the Crystal Sword - ");
            Write.Line(25, 18, "[A]bsorb the knowledge and rise in Level - ");
            Write.Line(55, 28, "[L]eave - ");
        }
        else Write.Line(visitedFlavor);
        Write.Line(55, 28, "[L]eave - ");
        if(!visited) good = true;

        string choice = Return.Option();
        //need to make it so the items and levels actually get set/equipted
        if (choice == "t" && !visited)
        {
            Console.Clear();
            Write.Line(40, 20, "You pull the glowing and mighty sword from the its sheath. It hums with overwhelming power.");
            Write.Line(40, 21, "The pedastool across the room is quickly lowered bellow the floor and it dissapears.");
            Program.p.Equip(Items.crystalSword);
            Write.KeyPress();
            good = false;
            visited = true;

        }
        else if (choice == "a" && !visited )
        {
            
            Console.Clear();
            Write.Line(40, 20, "You hand draws near the power from within the orb flows into you. Your power and knowledge grow!");
            Write.Line(40, 21, "The pedastool across the room is quickly lowered bellow the floor and it dissapears.");
            Combat.rewardXp += 100;
            Write.KeyPress();
            good = false;
            visited = true;


        }
        
        else if (choice == "l")
        {
            Console.Clear();
            Write.Line(40, 20, "You head back out the door");
            Write.KeyPress();
        }
        
    }
}
