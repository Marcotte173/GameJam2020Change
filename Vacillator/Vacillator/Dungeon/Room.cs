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
        int summonRoll = Return.RandomInt(1, 101);
        if (summonRoll < 35 + ((int)roomSize * 5)) Summon(2);
        else if (summonRoll < 80 + ((int)roomSize * 5)) Summon(1);
        else Alone();
    }

    protected void Summon(int howMany)
    {
        Console.Clear();
        int x = 50;
        int y = 14;
        Write.Line(x, y - 2, "You are discovered by...");
        Thread.Sleep(400);
        List<MonsterCreate> list = new List<MonsterCreate> { };
        list = (Manager.coreVisited < 2)? Monsters.list1: Monsters.list2;
        if (howMany == 2)
        {
            int summon1 = Return.RandomInt(0, list.Count);
            Monsters.Summon(list[summon1]);
            Write.Line(x, y, list[summon1].summon);
            int summon2 = Return.RandomInt(0, list.Count);
            Monsters.Summon(list[summon2]);
            Write.Line(x, y + 1, list[summon2].summon);
        }
        else if (howMany == 3)
        {
            int summon1 = Return.RandomInt(0, list.Count);
            Monsters.Summon(list[summon1]);
            Write.Line(x, y, list[summon1].summon);
            
            int summon2 = Return.RandomInt(0,list.Count);
            Monsters.Summon(list[summon2]);
            Write.Line(x, y + 1, list[summon2].summon);
            
            int summon3 = Return.RandomInt(0, list.Count);
            Monsters.Summon(list[summon3]);
            Write.Line(x, y + 2, list[summon3].summon);
        }
        else
        {
            int summon1 = Return.RandomInt(0, list.Count);
            Monsters.Summon(list[summon1]);
            Write.Line(x, y, list[summon1].summon);
        }
        Write.KeyPress(0, 28);
        visited = true;
        Manager.Vendor();
        Combat.Start();
    }

    public void Alone()
    {
        //Alone, search the room or move on
        Write.Line("You appear to be alone... for now");
        Write.Line(0, 25, "[S]earch the room");
        Write.Line(0, 26, "[M]ove on");
        string choice = Return.Option();
        if (choice == "m")
        {
            visited = true;
            Manager.Vendor();
        }
        else if (choice == "s") RoomSearch();
        else Alone();
    }

    protected void RoomSearch()
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
        Console.Clear();
        Console.Write("You were searching for a while, did anyone hear you?");
        Write.DotDotDotSL();
        int summonRoll = Return.RandomInt(1, 101);
        if (summonRoll > 80)
        {
            Write.Line(0, 10, "Phew, You got Lucky");
            Write.KeyPress();
        }
        else if (summonRoll < 30 + ((int)roomSize * 5))
        {
            Write.Line(0, 10, "Someone heard you! They're coming to investigate.\nSounds like there's a lot of them!");
            Summon(3);
        }
        else
        {
            Write.Line(0, 10, "Someone heard you! They're coming to investigate.");
            Summon(2);
        }        
    }

    public bool IsHallway() => roomType == RoomType.Hallway;
    public bool IsRoom() => roomType == RoomType.Room;
    public bool IsLibrary() => roomType == RoomType.Library;
    public bool IsTiny() => roomSize == RoomSize.Tiny;
    public bool IsSmall() => roomSize == RoomSize.Small;
    public bool IsLarge() => roomSize == RoomSize.Large;
}