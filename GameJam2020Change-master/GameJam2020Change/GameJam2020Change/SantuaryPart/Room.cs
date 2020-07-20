using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public enum RoomType {Hallway, Room, Library,  };
public enum RoomSize {Tiny, Small, Large } ;
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
        visited = true;
    }

    private void Summon(int howMany)
    {
        Console.Clear();
        int x = 50;
        int y = 14;
        Write.Line(x, y - 2, "You are discovered by...");
        Thread.Sleep(400);
        if(howMany == 2)
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
        Combat.Start();        
    }

    public void Alone()
    {
        //Alone, search the room or move on
        Write.Line("You appear to be alone... for now");
        Write.Line(0,25 ,"[S]earch the room");
        Write.Line(0,26, "[M]ove on");
        string choice = Return.Option();
        if (choice == "m") visited = true;
        else if (choice == "s") RoomSearch();
        else Alone();
    }

    private void RoomSearch()
    {
        //Find stuff, but chance of summon
    }

    public bool IsHallway() => roomType == RoomType.Hallway;
    public bool IsRoom() => roomType == RoomType.Room;
    public bool IsLibrary() => roomType == RoomType.Library;
    public bool IsTiny() => roomSize == RoomSize.Tiny;
    public bool IsSmall() => roomSize == RoomSize.Small;
    public bool IsLarge() => roomSize == RoomSize.Large;
}