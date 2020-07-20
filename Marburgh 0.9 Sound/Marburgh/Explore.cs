using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class Explore
{
    public static Dungeon d = new Dungeon();
    protected static Room starter;
    public static Shell currentShell;
    public static void Start()
    {
        Console.Clear();
        while (true)
        {
            if (currentShell.room.visited == false) currentShell.room.ExploreRoom();
            Navigate();
        }
    }

    public static void Navigate()
    {
        Console.Clear();
        UI();
    }

    private static void UI()
    {
        if (currentShell.room.visited == false) Write.Line("You are in a " + currentShell.room.name);
        else Write.Line(currentShell.room.visitedFlavor);
        if (currentShell.North > 0) Write.Line(55, 18, "[N]orth - ");
        if (currentShell.South > 0) Write.Line(55, 28, "[S]outh - ");
        if (currentShell.East > 0) Write.Line(30, 23, "[E]ast - ");
        if (currentShell.West > 0) Write.Line(80, 23, "[W]est - ");
        string choice = Return.Option();
        if (choice == "n" && currentShell.North > 0)
        {
            if (d.shell[currentShell.North].room.visited == false) ExploringText();
            ChangeShell(currentShell.North);
        }
        else if (choice == "s" && currentShell.South > 0)
        {
            if (d.shell[currentShell.South].room.visited == false) ExploringText();
            ChangeShell(currentShell.South);
        }
        else if (choice == "e" && currentShell.East > 0)
        {
            if (d.shell[currentShell.East].room.visited == false) ExploringText();
            ChangeShell(currentShell.East);
        }
        else if (choice == "w" && currentShell.West > 0)
        {
            if (d.shell[currentShell.West].room.visited == false) ExploringText();
            ChangeShell(currentShell.West);
        }
        else Navigate();
    }

    private static void ExploringText()
    {
        Console.Clear();
        Write.Line(40, 22, "     ^ ***^                    ");
        Write.Line(40, 23, "    (      )                   ");
        Write.Line(40, 24, "    |      |                   ");
        Write.Line(40, 25, "    |      |                   ");
        Write.Line(40, 26, "    |      |                   ");
        Write.Line(40, 27, "     \\    /                    ");
        Write.Line(40, 28, "      \\__/                     ");
        Thread.Sleep(400);
        Write.Line(60, 14, "     ^ ***^                    ");
        Write.Line(60, 15, "    (      )                   ");
        Write.Line(60, 16, "    |      |                   ");
        Write.Line(60, 17, "    |      |                   ");
        Write.Line(60, 18, "    |      |                   ");
        Write.Line(60, 19, "     \\    /                    ");
        Write.Line(60, 20, "      \\__/                     ");
        Thread.Sleep(400);
        Write.Line(40, 6, "     ^ ***^                    ");
        Write.Line(40, 7, "    (      )                   ");
        Write.Line(40, 8, "    |      |                   ");
        Write.Line(40, 9, "    |      |                   ");
        Write.Line(40, 10, "    |      |                   ");
        Write.Line(40, 11, "     \\    /                    ");
        Write.Line(40, 12, "      \\__/                     ");
        Thread.Sleep(400);

    }

    private static void ChangeShell(int connect)
    {
        currentShell = d.shell[connect];
    }
}
