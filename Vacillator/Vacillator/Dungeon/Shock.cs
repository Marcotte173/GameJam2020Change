using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Shock : Room

{
    

    

    public Shock()
    {
        flavor = "it is the train conondrum";

        visitedFlavor = "There is no lives left to save here, no lives left to take.";
        name = "Room with a Cage";
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
            Write.Line("You are in the room with the switch");
            
            Write.Line(75, 18, "[D]o Nothing and let "+Color.BLOOD+"3"+Color.RESET+ " die - ");
            Write.Line(25, 18, "[F]lip the switch and doom " + Color.BLOOD + "1" + Color.RESET + " person - ");
            if (Program.p.weapon != Items.noWeapon) Write.Line(25, 18, "[R]emove the head of the dopleganger before the guitine does. Losing your weapon in the process");

        }
        else Write.Line("There is no lives left to save here, no lives left to take."); Write.Line(55, 28, "[L]eave - ");


        string choice = Return.Option();

        if (choice == "f" && !visited)
        {
            

            Console.Clear();
            Write.Line(40, 20, "dopplegangers head roles");
            Write.KeyPress();
            good = false;
      
            
        }
        else if (choice == "r" && !visited && (Program.p.weapon != Items.noWeapon))
        {
            Program.p.weapon = Items.noWeapon.Copy();
            Console.Clear();
            Write.Line(40, 20, "you killed him");
            Write.KeyPress();
            good = false;
            
            
        }
        else if (choice == "d" && !visited)
        {
            Console.Clear();
            Write.Line(40, 20, "bing bam bop");
            Write.KeyPress();
            good = true;
            
        }
        else if (choice == "l")
        {
            Console.Clear();
            Write.Line(40, 20, "You head back out the door");
            Write.KeyPress();
        }
        visited = true;
    }
}
