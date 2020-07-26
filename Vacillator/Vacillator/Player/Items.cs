using System;
using System.Collections.Generic;
using System.Text;

public class Items
{
    /// <summary>
    /// Slot is empty
    /// </summary>
    public static Equipment noWeapon = new Equipment(Color.GREY + "Fist" + Color.RESET, 1, 0, 0, 0, EquipmentType.Weapon, 0);
    public static Equipment noArmor = new Equipment(Color.GREY + "None" + Color.RESET, 0, 0, 0, 0, EquipmentType.Armor, 0);

    /// <summary>
    ///  WEAPONS
    /// </summary>
    public static Equipment dagger = new Equipment(Color.ITEM + "Dagger" + Color.RESET, 3, 3, 0, 0, EquipmentType.Weapon, 200);
    public static Equipment redDagger = new Equipment(Color.ITEM + "Red Dagger" + Color.RESET, 6, 4, 0, 0, EquipmentType.Weapon, 350);
    public static Equipment blueDagger = new Equipment(Color.ITEM + "Blue dagger" + Color.RESET, 8, 5, 0, 0, EquipmentType.Weapon, 600);
    public static Equipment sword = new Equipment(Color.ITEM + "Sword" + Color.RESET, 10, 5, 0, 0, EquipmentType.Weapon, 800);
    public static Equipment redSword = new Equipment(Color.ITEM + "Red Sword" + Color.RESET, 14, 6, 0, 0, EquipmentType.Weapon, 1200);
    public static Equipment blueSword = new Equipment(Color.ITEM + "Blue Sword" + Color.RESET, 16, 7, 0, 0, EquipmentType.Weapon, 1500);
    public static Equipment crystalSword = new Equipment(Color.ITEM + "Crystal Sword" + Color.RESET, 20, 10, 0, 0, EquipmentType.Weapon, 3000);

    //////
    /// Torso Armor
    //////
    public static Equipment clothArmor = new Equipment(Color.ITEM + "Cloth Armor" + Color.RESET, 5, 1, 0, 0, EquipmentType.Armor, 200);
    public static Equipment leatherArmor = new Equipment(Color.ITEM + "Leather Armor" + Color.RESET, 3, 2, 0, 0, EquipmentType.Armor, 350);
    public static Equipment chainArmor = new Equipment(Color.ITEM + "Chain Chest" + Color.RESET, 1, 3, 0, 0, EquipmentType.Armor, 600);
    public static Equipment plateArmor = new Equipment(Color.ITEM + "Plate Chest" + Color.RESET, -3, 5, 0, 0, EquipmentType.Armor, 800);
    public static Equipment redArmor = new Equipment(Color.ITEM + "Red Armor" + Color.RESET, 2, 5, 0, 0, EquipmentType.Armor, 1200);
    public static Equipment blueArmor = new Equipment(Color.ITEM + "Blue Chest" + Color.RESET, 3, 5, 0, 0, EquipmentType.Armor, 1500);
    public static Equipment crystalArmor = new Equipment(Color.ITEM + "Crystal Chest" + Color.RESET, 10, 10, 0, 0, EquipmentType.Armor, 3000);

    public static Equipment apple = new Equipment(Color.YELLOW + "Apple", 0, 3, 0, 0, EquipmentType.Consumable, 150);
    public static Equipment potion = new Equipment(Color.YELLOW + "Potion", 0, 5, 0, 0, EquipmentType.Consumable, 100);
    public static Equipment chicken = new Equipment(Color.YELLOW + "Chicken", 0, 10, 0, 0, EquipmentType.Consumable, 250);

    public static List<Equipment> weapons = new List<Equipment> { noWeapon, dagger, redDagger, blueDagger, sword, redSword, blueSword, crystalSword };
    public static List<Equipment> armors = new List<Equipment> { noArmor, clothArmor, leatherArmor, chainArmor, plateArmor, redArmor, blueArmor, crystalArmor };
    public static List<Equipment> consumableList = new List<Equipment> { apple, potion, chicken };
}
