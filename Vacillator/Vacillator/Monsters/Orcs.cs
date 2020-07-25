using System;
using System.Collections.Generic;
using System.Text;

public class Orc : MonsterCreate
{
    public Orc(int level)
    : base()
    {
        name = Color.MONSTER + "Orc" + Color.RESET;
        summon = Color.MONSTER + "An Orc" + Color.RESET;
        hp = maxHp = 10 * level + (3 * level);
        damage = 3 + 2 * level;
        hit = 5 * level;
        crit = 3 * level;
        defence = 3 * level;
        mitigation = level;
        xp = level * 3;
        gold = level * Return.RandomInt(10, 15);
    }
}
