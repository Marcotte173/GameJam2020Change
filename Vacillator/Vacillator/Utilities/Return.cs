using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Return
{
    public static string[] info = new string[12];
    public static List<string> items = new List<string> {};
    static Random rand = new Random();
    internal static string String() => Console.ReadLine();
    public static bool Confirm(string choice)
    {
        Write.Line($"{choice}\n\n");
        Write.Line("[" + Color.ITEM + "Y" + Color.RESET + "]es \t [" + Color.BLOOD + "N" + Color.RESET + "]o\n");
        string choose = Return.Option();
        return (choose == "y");
    }
    public static string Option() => Console.ReadKey(true).KeyChar.ToString().ToLower();
    internal static int RandomInt(int min, int max) => rand.Next(min, max);
    internal static bool HaveGold(int price) => (Program.p.gold >= price);
    internal static bool HaveEnergy(int energyCost) => (Program.p.energy >= energyCost);
    internal static int Int()
    {
        int sellChoice;
        do
        {

        } while (!int.TryParse(Console.ReadKey(true).KeyChar.ToString().ToLower(), out sellChoice));
        return sellChoice;
    }
    internal static int Integer()
    {
        int sellChoice;
        do
        {

        } while (!int.TryParse(Console.ReadLine(), out sellChoice));
        return sellChoice;
    }

    internal static void PlayerInfo()
    {
        for (int i = 0; i < info.Length; i++)
        {
            Write.Line(70, 16 + i, info[i]);
        }
        if (items.Count > 0)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Write.Line(100, 16 + i, items[i]);
            }
        }        
    }

    internal static void ClassAdd()
    {
        if (Program.p.characterClass != Class.Adventurer) info[1] = "Class  : " + Color.ABILITY + Program.p.characterClass;
        else info[1] = "Class  : " + Color.SPEAK + Program.p.characterClass;
    }

    internal static void HealthEnergyAdd()
    {     
        info[3] = "Health : " + Color.HEALTH + Program.p.hp + Color.RESET + " / " + Color.HEALTH + Program.p.maxHp;
        info[4] = "Energy : " + Color.ENERGY + Program.p.energy + Color.RESET + " / " + Color.ENERGY + Program.p.maxEnergy;
    }

    internal static void NameAdd()
    {
        info[0] = "Name   : " + Color.NAME + Program.p.name;
    }

    internal static void ItemAdd()
    {
        info[6]  = "Weapon : " + Color.ITEM + Program.p.weapon.name;
        info[7]  = "Armor  : " + Color.ITEM + Program.p.armor.name;
        info[11] = "Gold   : " + Color.GOLD + Program.p.gold;
        items.Clear();
        items.Add(Color.ITEM + "Inventory"+ Color.RESET);
        items.Add("");
        foreach (Equipment e in Program.p.inventory) items.Add(e.name);
    }
}