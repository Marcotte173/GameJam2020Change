using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

public enum EquipmentType { Armor, Weapon, Consumable }
public class Equipment
{
    public string name;
    public int hp;
    public int maxHp;
    public int damage;
    public int offence;
    public int effect1;
    public int effect2;
    public int energyBonus;
    public int spellpowerBonus;
    public EquipmentType type;
    public int value;

    public Equipment(string name, int effect1, int effect2, int energyBonus, int spellpowerBonus, EquipmentType type, int value)
    {
        this.name = name;
        this.effect1 = effect1;
        this.type = type;
        this.value = value;
        this.effect2 = effect2;
        this.energyBonus = energyBonus;
        this.spellpowerBonus = spellpowerBonus;
    }

    public Equipment Copy()
    {
        return (Equipment)MemberwiseClone();
    }
}
