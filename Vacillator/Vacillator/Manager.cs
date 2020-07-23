using System;
using System.Collections.Generic;
using System.Text;

public class Manager
{
    public static bool mage;
    public static bool rogue;
    public static bool warrior;
    public int coreRooms;
    public static int resetVendor = 2;

    public static void Vendor()
    {
        resetVendor--;
        if (resetVendor <= 0)
        {
            resetVendor = 2;
            Dungeon.v.Restock();
        }
    } 
}