using System;
using System.Collections.Generic;
using System.Text;

public class Monsters
{
    public static void Summon(MonsterCreate m)
    {
        Combat.monsterList.Add(m.Copy());
    }
    ///Kobalds
    ///
    public static List<MonsterCreate> kobalds = new List<MonsterCreate> { null, new Kobald(1), new Kobald(2), new Kobald(3) };
    ///Orc
    ///
    public static List<MonsterCreate> orcs = new List<MonsterCreate> { null, new Orc(1), new Orc(2), new Orc(3) };
    ///Slime
    ///
    public static List<MonsterCreate> slimes = new List<MonsterCreate> { null, new Slime(1), new Slime(2), new Slime(3) };
    ///Goblin
    ///
    public static List<MonsterCreate> goblins = new List<MonsterCreate> { null, new Goblin(1), new Goblin(2), new Goblin(3) };

    
    public static MonsterCreate kobald = new Kobald();
    public static MonsterCreate slime = new Slime();
    public static MonsterCreate goblin = new Goblin();

    public static List<MonsterCreate> list = new List<MonsterCreate> { kobald, slime, goblin };
}