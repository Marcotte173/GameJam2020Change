using System;
using System.Collections.Generic;
using System.Text;

public class Slime : MonsterCreate
{
    public Slime(int level)
    : base()
    {
        name = Color.MONSTER + "Slime" + Color.RESET;
        summon = Color.MONSTER + "A Slime" + Color.RESET;
        hp = maxHp = 10 * level + (3 * level);
        damage = 3 + 2 * level;
        hit = 5 * level;
        crit = 3 * level;
        defence = 3 * level;
        mitigation = level;
        xp = level * 3;
        gold = level * Return.RandomInt(10, 15);
    }
    public Slime()
    : base()
    {
        name = Color.MONSTER + "Slime" + Color.RESET;
        summon = Color.MONSTER + "A Slime" + Color.RESET;
        hp = maxHp = 12;
        damage = 6;
        hit = 6;
        crit = 10;
        defence = 20;
        mitigation = 1;
        xp = 7;
        gold = Return.RandomInt(10, 35);
    }
}