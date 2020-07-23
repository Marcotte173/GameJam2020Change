using System;
using System.Collections.Generic;
using System.Text;

public class Manager
{
    public static bool mage;
    public static bool rogue;
    public static bool warrior;
    public int coreRooms;
    public static int resetVendor;
    public static int visited;
    public static int coreVisited;

    public static void Vendor()
    {
        visited++;
        resetVendor--;
        if (resetVendor <= 0)
        {
            resetVendor = 2;
            Dungeon.v.Restock();
        }
    } 
}