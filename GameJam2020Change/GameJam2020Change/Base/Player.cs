using System;
using System.Collections.Generic;
using System.Text;

public class Player:Creature
{
    public int gold;
    public Item weapon;
    public Item armor;
    public List<Item> invitory;
        public Player()
    : base()
    {
        typeName = "Adventurer";
        maxHp = hp = 40;
        energy = maxEnergy = 0;
        damage = 6;
        mitigation = 1;
        hit = 65;
        crit = 5;
        defence = 0;
        spellpower = 0;
    }

    public void Equip(Item e)
    {
        //UI Telling you what happened
        if (e.weapon) weapon = e;
        else armor = e;
    }

    public void GetTarget()
    {

    }
}
