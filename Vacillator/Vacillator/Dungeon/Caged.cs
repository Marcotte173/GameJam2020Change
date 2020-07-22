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
        else Write.Line(0, 10, flavor);
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
                if (item.type == EquipmentType.Consumable) Program.p.inventory.Remove(item);
            }
            
            Console.Clear();
            Write.Line(40, 20, "Hungry Boi Eat");
            Write.KeyPress();
            visitedFlavor = "You enter a room with the prisoner who is fed.\nHe smiles.";
            visited = true;
        }
        else if (choice == "r" && !visited)
        {
            Console.Clear();
            Write.Line(40, 20, "He run away");
            Write.KeyPress();
            visitedFlavor = "You enter a room with an empty cage.\nThe prisoner is gone";
            visited = true;
        }
        else if (choice == "k" && !visited)
        {
            Console.Clear();
            Write.Line(40, 20, "oh boi he ded");
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
