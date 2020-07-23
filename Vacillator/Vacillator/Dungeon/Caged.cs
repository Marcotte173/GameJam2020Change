using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Caged : Room

{

    public bool haveFood;

    public Caged()
    {
        flavor = "You walk into a room that has a skylight coming from the ceiling, illuminating a domelike cage bolted into the ground.\nInside sits a person, or at least you think it is a person.\nThey are sitting on the floor, clutching their knees, looking at the floor, and mumbling.\nThey look at you, and then at your keys, and then look back down at the ground.\n";

        visitedFlavor = "NOT YET";
        name = "Room with a Cage";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else
        {
            Write.Line(10, 10, "You walk into a room that has a skylight coming from the ceiling,");
            Write.Line(10, 11, "illuminating a domelike cage bolted into the ground. it is too small for what it contains.");
            Write.Line(10, 12, "Inside sits a person, or at least you think it is a person.");
            Write.Line(10, 13, "They are sitting on the floor, clutching their knees, looking at the floor, and mumbling.");
            Write.Line(10, 14, "They look at you, and then at your keys, and then look back down at the ground.");
        }
        Write.KeyPress();
        Interact();

    }


    public void Interact()
    {
        foreach (Equipment item in Program.p.inventory)
        {
            if (item.type == EquipmentType.Consumable) haveFood = true;
        }


        Console.Clear();
        if (!visited)
        {
            Write.Line("You are in a room with a Cage.");
            if (haveFood) Write.Line(50, 18, "[F]eed Prisoner - ");
            Write.Line(75, 18, "[R]elease Prisoner - ");
            Write.Line(25, 18, "[K]ill Prisoner - ");
        }
        else Write.Line("You seem to have made your choice here.");

        Write.Line(55, 28, "[L]eave - ");
        string choice = Return.Option();

        if (choice == "f" && !visited)
        {
            foreach (Equipment item in Program.p.inventory)
            {
                if (item.type == EquipmentType.Consumable)
                {
                    Program.p.inventory.Remove(item);
                    Console.Clear();
                    Write.Line(10, 20, "He takes the food gingerly in his hands. He consumes it, savoring it. He then sits, pleased, qiuet.");
                    Write.KeyPress();
                    visitedFlavor = "You enter a room with the prisoner who is fed.\nHe smiles.";
                    visited = true;
                    break;
                }
            }
            
            
        }
        else if (choice == "r" && !visited)
        {
            Console.Clear();
            Write.Line(10, 20, "The thing stands and bolts out of the cage. His legs carry him at an unatural pace");
            Write.Line(10, 21, "You hear what you think are his screams as he goes down the halls of Vacilators Mansion");
            Write.KeyPress();
            visitedFlavor = "You enter a room with an empty cage.\nThe prisoner is gone";
            visited = true;
        }
        else if (choice == "k" && !visited)
        {
            Console.Clear();
            Write.Line(10, 20, "You think this thing must be in here for a reason. You take it uppon yourself to end their suffering.");
            Write.Line(10, 21, "with the softest touch of a weapon, the thing collapses and gushes blood. It is dead.");
            Write.KeyPress();
            visitedFlavor = "You enter a room with a cage and a corpse.\nThe corpse has aged so much";
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
