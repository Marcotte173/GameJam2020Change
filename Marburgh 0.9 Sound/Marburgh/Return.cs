using System;
using System.Collections.Generic;
using System.Text;

public class Return
{
    static Random rand = new Random();
    internal static string String() => Console.ReadLine();
    public static bool Confirm(string choice)
    {
        Write.Line($"{choice}\n\n");
        Write.Line("[Y]es \t [N]o\n");
        string choose = Return.Option();
        return (choose == "y");
    }
    public static string Option() => Console.ReadKey(true).KeyChar.ToString().ToLower();
    internal static int RandomInt(int min, int max) => rand.Next(min, max);
    internal static bool HaveGold(int price) => (GameJam2020Change.Program.p.gold >= price);
    internal static bool HaveEnergy(int energyCost) => (GameJam2020Change.Program.p.energy >= energyCost);
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
}