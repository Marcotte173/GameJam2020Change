using System;
using System.Collections.Generic;
using System.Text;

public class Kobald : MonsterCreate
{
    public Kobald(int level)
    : base()
    {
        name = Color.MONSTER + "Kobold" + Color.RESET;
        summon = Color.MONSTER + "A Kobold" + Color.RESET;
        hp = maxHp = 10 * level + (3 * level);
        damage = 3 + 2 * level;
        hit = 5 * level;
        crit = 3 * level;
        defence = 3 * level;
        mitigation = level;
        xp = level * 3;
        gold = level * Return.RandomInt(10, 15);
    }

    public Kobald()
    : base()
    {
        name = Color.MONSTER + "Kobold" + Color.RESET;
        summon = Color.MONSTER + "A Kobold" + Color.RESET;
        hp = maxHp = 9;
        damage = 7;
        hit = 5;
        crit = 15;
        defence = 7;
        mitigation = 1;
        xp = 7;
        gold = Return.RandomInt(10, 35);
    }
}