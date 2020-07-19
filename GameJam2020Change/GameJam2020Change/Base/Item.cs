using System;
using System.Collections.Generic;
using System.Text;

public class Item
{
    public string name;
    public bool weapon;
    public static List<Item> weaponList = new List<Item>
    {
        new Weapon("None", 3,0,0),
        new Weapon("Dagger", 5,2,3),
        new Weapon("Short Sword", 9,4,2),
        new Weapon("Long Sword", 12,5,2)
    };
    public static List<Item> armorList = new List<Item>
    {
        new Armor("None", 0,5),
        new Armor("Cloth Armor", 1,10),
        new Armor("Leather Armor", 2,8),
        new Armor("Hardened Leather", 3,8),
    };
    public static List<Item> consumableList = new List<Item>
    {
        new Armor("None", 0,0),
        new Armor("Apple", 1,5),
        new Armor("Potion", 10,0),
        new Armor("Chicken", 12,10),
    };

    public Item()
    {

    }
}
