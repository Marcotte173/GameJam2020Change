using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Shock : Room

{

    

    public Shock()
    {
        flavor = "The sounds of gears and gasses fill the air, much more sofisticated than anything you have ever seen.";

        visitedFlavor = "There is no lives left to save here, no lives left to take.";
        name = "Room with machines";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(10, 10, flavor);
        Write.KeyPress();
        Interact();

    }


    public void Interact()
    {
        Console.Clear();
        if (!visited)
        {
            Write.Line(10,10,"You are in the room with the switch");
            Write.Line(10, 11, "Beyond the switch are mechanisms beyond things you have ever seen.");
            Write.Line(10, 12, "They resemble guiatines that are much more complex that what you know.");
            Write.Line(10, 10, "There are 4 people in the room, all of them unconscious, all of them look exactly like you.");
            Write.Line(10, 13, "The machines hold the people in place.");
            Write.Line(10, 14,"One holds 3 people and a timer that is quickly counting down.");
            Write.Line(10, 15, "The other holds 1 person with a paused timer.");
            Write.Line(10, 16, "The lever seems to control who will live and who will die");

            //might need some readjusting on spacing
            Write.Line(10, 18, "[D]o Nothing and let "+Color.BLOOD+"3"+Color.RESET+ " die - ");
            Write.Line(35, 18, "[F]lip the switch and doom " + Color.BLOOD + "1" + Color.RESET + " person - ");
            if (Program.p.weapon != Items.noWeapon) Write.Line(60, 18, "[R]emove all their heads before anything else can.(loose weapon)");

        }
        else Write.Line("There is no lives left to save here, no lives left to take."); Write.Line(55, 28, "[L]eave - ");


        string choice = Return.Option();
        //ALL FLAVOR TEXT MUST BE REVISED
        if (choice == "f" && !visited)
        {
            
            Console.Clear();
            Write.Line(40, 20, "dopplegangers head roles");
            Write.KeyPress();
      
            
        }
        //checks if you have a weapon and then gets rid of it
        else if (choice == "r" && !visited && (Program.p.weapon != Items.noWeapon))
        {
            Program.p.weapon = Items.noWeapon.Copy();
            Console.Clear();
            Write.Line(40, 20, "you killed him");
            Write.KeyPress();
            
            
        }
        else if (choice == "d" && !visited)
        {
            Console.Clear();
            Write.Line(40, 20, "bing bam bop");
            Write.KeyPress();
            
            
        }
        else if (choice == "l" && visited)
        {
            Console.Clear();
            Write.Line(40, 20, "You head back out the door");
            Write.KeyPress();
        }
        visited = true;
    }
}
