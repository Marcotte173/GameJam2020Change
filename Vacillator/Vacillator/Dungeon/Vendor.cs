using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Vendor : Room
{
    public static List<Equipment> list = new List<Equipment> { };

    public Vendor()
    {
        flavor = "You have walked into a room. A man stands behind a stall and becons you over to buy something.";

        visitedFlavor = "Welcome Back. Care to Look around?";

        name = "Room with a Vendor";
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(0, 10, flavor);
        Write.KeyPress();
        //clear vendor inventory and add 4 new items
        list.Clear();
        list.Add(Items.weapons[Return.RandomInt(1, Items.weapons.Count)]);
        list.Add(Items.armors[Return.RandomInt(1, Items.armors.Count)]);
        list.Add(Items.consumableList[Return.RandomInt(1, Items.consumableList.Count)]);
        list.Add(Items.consumableList[Return.RandomInt(1, Items.consumableList.Count)]);
        Interact();
    }


    public void Interact()
    {
        Console.Clear();
        Write.Line("The Vendor stands before you.\n\n'What can I interest you in?'\n\n");
        Console.SetCursorPosition(0, 6);
        //write availible items, green if buyable, grey if not
        for (int i = 0; i < list.Count; i++)
        {
            if (Return.HaveGold(list[i].value)) Write.Line("[" + Color.ITEM + (i + 1) + Color.RESET + "] " + Color.ITEM + list[i].name + Color.RESET + " - " + Color.GOLD + list[i].value + Color.RESET);
            else Write.Line(Color.GREY + "[X] " + list[i].name + " - " + list[i].value + Color.RESET);
        }
        Write.Line(0, 26, "[0] Leave");
        //input and check if buyable, then equipt(change to add to invintory?)
        int choice = Return.Int();
        if (choice > 0 && choice < list.Count)
        {
            if (Return.HaveGold(list[choice - 1].value))
            {
                Console.Clear();
                if (Return.Confirm($"Would you like to purchase the {Color.ITEM + list[choice - 1].name + Color.RESET}?"))
                {
                    Write.Line("The vendor takes your money and give you the " + Color.ITEM + list[choice - 1].name + Color.RESET);
                    Program.p.gold -= list[choice - 1].value;
                    Program.p.Equip(list[choice - 1]);
                    list.RemoveAt(choice - 1);
                    Write.KeyPress();
                }
            }
            Interact();
        }
        else if (choice < 0 || choice > list.Count) Interact();
    }
}
