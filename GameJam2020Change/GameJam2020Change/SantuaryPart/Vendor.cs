using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Vendor:Room

{
    Program p = new Program();

    public Vendor()
    { 
        flavor = "You have walked into a room. A man stands behind a stall and becons you over to buy something.";

        visitedFlavor = "Welcome Back. Care to Look around?";

        name = "Room with a Vendor"; 
    }
    internal override void Explore()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else Write.Line(0,10,flavor);
        Write.KeyPress();
        Interact();
        
    }


    public void Interact()
    {
        Console.Clear();
        Write.Line("The Vendor stands before you.");

        var random = new Random();


        int item1 = random.Next(0, Item.armorList.Count);
        int costChoose1 = Return.RandomInt(25, 50);
        Write.Line("[1]Buy " + (Item)Item.armorList[item1]);
        
        int item2 = random.Next(0, Item.weaponList.Count);
        int costChoose2 = Return.RandomInt(10, 20);
        Write.Line("[2]Buy " + (Item)Item.weaponList[item2]);
        
        int item3 = random.Next(0, Item.consumableList.Count);
        int costChoose3 = Return.RandomInt(2, 10);
        Write.Line("[3]Buy " + (Item)Item.consumableList[item3]);
        string item3string = (Item)Item.consumableList[item3];

        int item4 = random.Next(0, Item.consumableList.Count);
        int costChoose4 = Return.RandomInt(2, 10);
        Write.Line("[4]Buy " + (Item)Item.consumableList[item4]);
        string item4string = (Item)Item.consumableList[item4];

        Write.Line(55,28,"[L]eave");
        string choice = Return.Option();

        if (choice == "1" && Return.HaveGold(costChoose1) == true)
        {
            Console.Clear();
            Write.Line(40,20,"Item bought");
            Write.KeyPress();
            GameJam2020Change.Program.p.gold -= costChoose1;
            GameJam2020Change.Program.p.Equip((Item)Item.armorList[item1]);
        }

        else if (choice == "1" && Return.HaveGold(costChoose2) == true)
        {
            Console.Clear();
            Write.Line(40,20,"Item bought");
            Write.KeyPress();
            GameJam2020Change.Program.p.gold -= costChoose2;
            GameJam2020Change.Program.p.Equip((Item)Item.weaponList[item2]);
        }

        else if (choice == "3" && Return.HaveGold(costChoose3) == true)
        {
            Console.Clear();
            Write.Line(40,20,"Item bought");
            Write.KeyPress();
            GameJam2020Change.Program.p.gold -= costChoose3;
            GameJam2020Change.Program.p.inventory.Add(new Item() {  name = item3string });
        }

        else if (choice == "4" && Return.HaveGold(costChoose4) == true)
        {
            Console.Clear();
            Write.Line(40,20,"Item bought");
            Write.KeyPress();
            GameJam2020Change.Program.p.gold -= costChoose4;
            GameJam2020Change.Program.p.inventory.Add(new Item() { name = item4string });
        }

        else
        {
            Console.Clear();
            Write.Line(40,20,"You dont have enough gold.");
        }
    }
}
