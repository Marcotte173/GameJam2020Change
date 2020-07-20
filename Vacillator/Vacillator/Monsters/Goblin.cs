using System;
using System.Collections.Generic;
using System.Text;

public class Goblin : MonsterCreate
{
    public Goblin(int level)
    : base()
    {
        name = Color.MONSTER + "Goblin" + Color.RESET;
        summon = Color.MONSTER + "A Goblin" + Color.RESET;
        hp = maxHp = 10 * level + (3 * level);
        damage = 3 + 2 * level;
        hit = 5 * level;
        crit = 3 * level;
        defence = 3 * level;
        mitigation = level;
        xp = level * 3;
        gold = level * Return.RandomInt(10, 15);
    }

    public Goblin()
    : base()
    {
        name = Color.MONSTER + "Goblin" + Color.RESET;
        summon = Color.MONSTER + "A Goblin" + Color.RESET;
        hp = maxHp = 10;
        damage = 8;
        hit = 15;
        crit = 10;
        defence = 7;
        mitigation = 1;
        xp = 7;
        gold = Return.RandomInt(10, 35);
    }
}