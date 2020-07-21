using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public enum RoomType { Hallway, Room, Library, };
public enum RoomSize { Tiny, Small, Large };
public class Room
{
    public string name;
    protected int type;
    public string flavor;
    public string visitedFlavor;
    public bool visited;
    public RoomType roomType;
    public RoomSize roomSize;

    public Room()
    {
        int sizeChoose = Return.RandomInt(0, 10);
        roomSize = (sizeChoose > 8) ? RoomSize.Large : (sizeChoose > 5) ? RoomSize.Small : RoomSize.Tiny;
        int typeChoose = Return.RandomInt(0, 10);
        roomType = (typeChoose > 8) ? RoomType.Library : (typeChoose > 1) ? RoomType.Room : RoomType.Hallway;
        string a = (IsHallway()) ? "hallway" : (IsRoom()) ? "room" : "library";
        string b = (IsTiny()) ? "tiny" : (IsSmall()) ? "small" : "large";
        flavor = "You are in a " + b + " " + a + ". Not bad. Spencer, help me out";
        visitedFlavor = "This is stil a " + b + " " + a + ".";
        name = b + " " + a;

    }

    internal virtual void ExploreRoom()
    {
        Console.Clear();
        Write.Line(40, 20, $"You enter a {Explore.currentShell.room.name}");
        Write.KeyPress();
        Console.Clear();
        if (Return.RandomInt(1, 101) < 10 + ((int)roomSize * 5)) Summon(3);
        else if (Return.RandomInt(1, 101) < 40 + ((int)roomSize * 5)) Summon(2);
        else if (Return.RandomInt(1, 101) < 80 + ((int)roomSize * 5)) Summon(1);
        else Alone();
    }

    protected void Summon(int howMany)
    {
        Console.Clear();
        int x = 50;
        int y = 14;
        Write.Line(x, y - 2, "You are discovered by...");
        Thread.Sleep(400);
        if (howMany == 2)
        {
            int summon1 = Return.RandomInt(0, Monsters.list.Count);
            Monsters.Summon(Monsters.list[summon1]);
            Write.Line(x, y, Monsters.list[summon1].summon);
            int summon2 = Return.RandomInt(0, Monsters.list.Count);
            Monsters.Summon(Monsters.list[summon2]);
            Write.Line(x, y + 1, Monsters.list[summon2].summon);
        }
        else if (howMany == 3)
        {
            int summon1 = Return.RandomInt(0, Monsters.list.Count);
            Monsters.Summon(Monsters.list[summon1]);
            Write.Line(x, y, Monsters.list[summon1].summon);
            int summon2 = Return.RandomInt(0, Monsters.list.Count);
            Monsters.Summon(Monsters.list[summon2]);
            Write.Line(x, y + 1, Monsters.list[summon2].summon);
            int summon3 = Return.RandomInt(0, Monsters.list.Count);
            Monsters.Summon(Monsters.list[summon3]);
            Write.Line(x, y, Monsters.list[summon3].summon);
        }
        else
        {
            int summon1 = Return.RandomInt(0, Monsters.list.Count);
            Monsters.Summon(Monsters.list[summon1]);
            Write.Line(x, y, Monsters.list[summon1].summon);
        }
        Write.KeyPress(0, 28);
        visited = true;
        Combat.Start();
    }

    public void Alone()
    {
        //Alone, search the room or move on
        Write.Line("You appear to be alone... for now");
        Write.Line(0, 25, "[S]earch the room");
        Write.Line(0, 26, "[M]ove on");
        string choice = Return.Option();
        if (choice == "m") visited = true;
        else if (choice == "s") RoomSearch();
        else Alone();
    }

    private void RoomSearch()
    {
        Console.Clear();
        Console.Write("Searching");
        Write.DotDotDotSL();
        int whatDoIFind = Return.RandomInt(0, 20);
        if (whatDoIFind < 6) Write.Line(0, 8, "You find nothing!");
        else if (whatDoIFind < 17)
        {
            int gold = Return.RandomInt(10, 30);
            int xp = Return.RandomInt(3, 10);
            Write.Line(0, 8, "You find gold and an old book!");
            Write.KeyPress();
            Console.Clear();
            Write.Line($"You find {gold} gold and an old book. Reading the book gives you {xp} experience");
        }
        else
        {
            Write.Line(0, 8, "You find an Item!");
            int itemRoll = Return.RandomInt(0, 5);
            Equipment e = Items.noWeapon;
            if (itemRoll < 3) e = Items.consumableList[Return.RandomInt(1,Items.consumableList.Count)];
            if (itemRoll == 3) e = Items.armors[Return.RandomInt(1, Items.armors.Count)];
            else e = Items.weapons[Return.RandomInt(1, Items.weapons.Count)];
            Write.KeyPress();
            Console.Clear();
            if(e.type != EquipmentType.Consumable)
            {
                if(Return.Confirm($"You find a {e.name}. Would you like to equip it?"))
                {
                    Write.Line($"\n\nYou equip the {e.name}");
                    Program.p.Equip(e);
                }                
            }
            else
            {
                if (Return.Confirm($"You find a {e.name}. Would you pick it up?"))
                {
                    Write.Line($"\n\nYou pick up the {e.name}");
                    Program.p.Equip(e);
                }
            }
        }
        Write.KeyPress();
    }

    public bool IsHallway() => roomType == RoomType.Hallway;
    public bool IsRoom() => roomType == RoomType.Room;
    public bool IsLibrary() => roomType == RoomType.Library;
    public bool IsTiny() => roomSize == RoomSize.Tiny;
    public bool IsSmall() => roomSize == RoomSize.Small;
    public bool IsLarge() => roomSize == RoomSize.Large;
}