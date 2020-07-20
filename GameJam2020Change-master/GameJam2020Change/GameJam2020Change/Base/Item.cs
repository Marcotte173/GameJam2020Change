using System;
using System.Collections.Generic;
using System.Text;

public class Item
{
    public string name;
    public bool weapon;
    public int value;
    public bool consumable;
    public static List<Item> weaponList = new List<Item>
    {
        new Weapon("None", 3,0,0,0),
        new Weapon("Dagger", 5,2,3,100),
        new Weapon("Short Sword", 9,4,2,200),
        new Weapon("Long Sword", 12,5,2,300)
    };
    public static List<Item> armorList = new List<Item>
    {
        new Armor("None", 0,5,0),
        new Armor("Cloth Armor", 1,10,100),
        new Armor("Leather Armor", 2,8,200),
        new Armor("Hardened Leather", 3,8,300),
    };
    public static List<Item> consumableList = new List<Item>
    {
        new Consumable("None", 0,0,0),
        new Consumable("Apple", 1,5,50),
        new Consumable("Potion", 10,0,100),
        new Consumable("Chicken", 12,10,150),
    };

    public Item()
    {

    }
}
