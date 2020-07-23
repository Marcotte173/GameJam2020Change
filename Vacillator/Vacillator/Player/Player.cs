using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Class { Adventurer, Warrior, Mage, Rogue }
public class Player : Creature
{
    public Class characterClass;
    public int maxEnergy;
    public int energy;
    public int spellPower;
    public int[] levelXp = new int[] { 0, 20, 50, 90, 140, 200 };
    public int level;

    public int[] aBaseDamage = { 0,  4,  6, 10 };
    public int[] wBaseDamage = { 0,  4,  6, 10 };    
    public int[] mBaseDamage = { 0,  4,  6,  9 };
    public int[] rBaseDamage = { 0,  5,  8, 13 };

    public int[] aBaseHp =     { 0, 50, 23, 31 };
    public int[] wBaseHp =     { 0, 60, 30, 38 };
    public int[] mBaseHp =     { 0, 45, 22, 30 };    
    public int[] rBaseHp =     { 0, 50, 24, 32 };


    public int[] wBaseEnergy = { 0, 2, 2, 3 };
    public int[] wBaseSpellpower = { 0, 0, 0, 0 };
    public int[] wBaseDefence = { 0, 5, 12, 18 };
    public int[] wBaseHit = { 0, 5, 10, 15 };
    public int[] wBaseCrit = { 0, 5, 6, 7 };
    public int[] wBaseMitigation = { 0, 1, 3, 4 };

    
    
    public int[] aBaseEnergy = { 0, 0, 0, 0 };
    public int[] aBaseSpellpower = { 0, 0, 0, 0 };
    public int[] aBaseDefence = { 0, 5, 10, 15 };
    public int[] aBaseHit = { 0, 5, 10, 15 };
    public int[] aBaseCrit = { 0, 5, 6, 7 };
    public int[] aBaseMitigation = { 0, 1, 2, 3 };

    
    
    public int[] rBaseEnergy = { 0, 2, 2, 3 };
    public int[] rBaseSpellpower = { 0, 0, 0, 0 };
    public int[] rBaseDefence = { 0, 5, 10, 15 };
    public int[] rBaseHit = { 0, 6, 12, 18, };
    public int[] rBaseCrit = { 0, 5, 8, 11 };
    public int[] rBaseMitigation = { 0, 1, 2, 3 };

    
    
    public int[] mBaseEnergy = { 0, 3, 3, 4 };
    public int[] mBaseSpellpower = { 0, 1, 2, 2 };
    public int[] mBaseDefence = { 0, 5, 10, 15 };
    public int[] mBaseHit = { 0, 5, 10, 15 };
    public int[] mBaseCrit = { 0, 5, 6, 7 };
    public int[] mBaseMitigation = { 0, 1, 2, 3 };

    public int damageBonus;
    public int hpBonus;
    public int hitBonus;
    public int critBonus;
    public int mitigationBonus;
    public int defenceBonus;
    public int spellpowerBonus;
    public int energyBonus;
    public int potion;
    public int maxPotion;
    public int potionLevel;
    public int[] potionHp = new int[] { 0, 10, 15, 20, 25 };
    public int[] potionPrice = new int[] { 0, 200, 300, 500, 600, 700 };
    public bool ability1;
    public bool ability2;
    public string abilityName1;
    public string abilityName2;
    public bool canExplore;
    public Equipment weapon;
    public Equipment armor;
    public List<Equipment> inventory = new List<Equipment> { };
    public Player() { }
    public Player(Class characterClass)
    : base()
    {
        canExplore = true;
        potionLevel = 1;
        potion = maxPotion = potionHp[potionLevel];
        this.characterClass = characterClass;
        gold = 200;
        level = 1;
        xp = 0;
        if (characterClass == Class.Warrior)
        {
            hp = maxHp = wBaseHp[level];
            damage = wBaseDamage[level];
            energy = maxEnergy = wBaseEnergy[level];
            spellPower = wBaseSpellpower[level];
            defence = wBaseDefence[level];
            hit = wBaseHit[level];
            crit = wBaseCrit[level];
            mitigation = wBaseMitigation[level];
            weapon = Items.noArmor.Copy();
            armor = Items.clothArmor.Copy();
            abilityName1 = "Defence Boost";
            abilityName2 = "Shout";
        }
        else if (characterClass == Class.Rogue)
        {
            hp = maxHp = rBaseHp[level];
            damage = rBaseDamage[level];
            energy = maxEnergy = rBaseEnergy[level];
            spellPower = rBaseSpellpower[level];
            defence = rBaseDefence[level];
            hit = rBaseHit[level];
            crit = rBaseCrit[level];
            mitigation = rBaseMitigation[level];
            weapon = Items.dagger.Copy();
            armor = Items.noArmor.Copy();
            abilityName1 = "Backstab";
            abilityName2 = "Stealth";
        }
        else if (characterClass == Class.Mage)
        {
            hp = maxHp = mBaseHp[level];
            damage = mBaseDamage[level];
            energy = maxEnergy = mBaseEnergy[level];
            spellPower = mBaseSpellpower[level];
            defence = mBaseDefence[level];
            hit = mBaseHit[level];
            crit = mBaseCrit[level];
            mitigation = mBaseMitigation[level];
            weapon = Items.noWeapon.Copy();
            armor = Items.noArmor.Copy();
            abilityName1 = "Fireball";
            abilityName2 = "Shield";
        }
        else if (characterClass == Class.Adventurer)
        {
            hp = maxHp = aBaseHp[level];
            damage = aBaseDamage[level];
            energy = maxEnergy = aBaseEnergy[level];
            spellPower = aBaseSpellpower[level];
            defence = aBaseDefence[level];
            hit = aBaseHit[level];
            crit = aBaseCrit[level];
            mitigation = aBaseMitigation[level];
            weapon = Items.noWeapon.Copy();
            armor = Items.noArmor.Copy();
            abilityName1 = "Adventurers have no abilities";
            abilityName1 = "Adventurers have no abilities";
        }
    }

    public void Equip(Equipment e)
    {
        //UI Telling you what happened
        if (e.type == EquipmentType.Weapon) weapon = e.Copy();
        else if (e.type == EquipmentType.Consumable)
        {
            inventory.Add(e.Copy());
            Return.items.Add(e.name);
        }
        else armor = e.Copy();

    }

    internal void LevelUp()
    {
        xp -= levelXp[level];
        Console.Clear();
        level++;
        Write.Line(40, 14, $"You are now level {level}");
        if (characterClass == Class.Warrior)
        {
            hp = maxHp = wBaseHp[level];
            damage = wBaseDamage[level];
            energy = maxEnergy = wBaseEnergy[level];
            spellPower = wBaseSpellpower[level];
            defence = wBaseDefence[level];
            hit = wBaseHit[level];
            crit = wBaseCrit[level];
            mitigation = wBaseMitigation[level];
        }
        else if (characterClass == Class.Rogue)
        {
            hp = maxHp = rBaseHp[level];
            damage = rBaseDamage[level];
            energy = maxEnergy = rBaseEnergy[level];
            spellPower = rBaseSpellpower[level];
            defence = rBaseDefence[level];
            hit = rBaseHit[level];
            crit = rBaseCrit[level];
            mitigation = rBaseMitigation[level];
        }
        else if (characterClass == Class.Mage)
        {
            hp = maxHp = mBaseHp[level];
            damage = mBaseDamage[level];
            energy = maxEnergy = mBaseEnergy[level];
            spellPower = mBaseSpellpower[level];
            defence = mBaseDefence[level];
            hit = mBaseHit[level];
            crit = mBaseCrit[level];
            mitigation = mBaseMitigation[level];
        }
        Write.Line(40, 10, $"Your base hitpoints are now {maxHp}");
        Write.Line(40, 11, $"Your base energy is now {maxEnergy}");

        Write.Line(40, 13, $"Your base damage is now {damage}");
        Write.Line(40, 14, $"Your base spellpower is now {spellPower}");

        Write.Line(40, 16, $"Your base hit is now {hit}");
        Write.Line(40, 17, $"Your base crit is now {crit}");
        Write.Line(40, 18, $"Your base defence is now {defence}");
        Write.Line(40, 19, $"Your base mitigation is now {mitigation}");
        Write.KeyPress(0, 28);
    }

    internal void CastAbility1()
    {
        energy--;
        if (characterClass == Class.Warrior)
        {
            defenceBonus += 20;
            Combat.combatText.Add($"Your defence value has raised by 20");
            Combat.combatText.Add("until the end of combat");
            Combat.CombatLoop();
        }
        if (characterClass == Class.Rogue)
        {
            if (Combat.monsterList.Count == 2)
            {
                Write.Line(45, 8, "Select your target");
                string choice = Return.Option();
                if (choice == "1") Combat.monsterList[0].TakeDamage(Damage + weapon.effect1 * 2, $"You backstab the {Combat.monsterList[0].name} for {Damage + weapon.effect1 * 2} damage");
                else if (choice == "2") Combat.monsterList[1].TakeDamage(Damage + weapon.effect1 * 2, $"You backstab the {Combat.monsterList[1].name} for {Damage + weapon.effect1 * 2} damage");
                else if (choice == "3") Combat.monsterList[2].TakeDamage(Damage + weapon.effect1 * 2, $"You backstab the {Combat.monsterList[2].name} for {Damage + weapon.effect1 * 2} damage");
                else CastAbility1();
            }
            if (Combat.monsterList.Count == 2)
            {
                Write.Line(45, 8, "Select your target");
                string choice = Return.Option();
                if (choice == "1") Combat.monsterList[0].TakeDamage(Damage + weapon.effect1 * 2, $"You backstab the {Combat.monsterList[0].name} for {Damage + weapon.effect1 * 2} damage");
                else if (choice == "2") Combat.monsterList[1].TakeDamage(Damage + weapon.effect1 * 2, $"You backstab the {Combat.monsterList[1].name} for {Damage + weapon.effect1 * 2} damage");
                else CastAbility1();
            }
            else Combat.monsterList[0].TakeDamage(Damage + weapon.effect1 * 2, $"You backstab the {Combat.monsterList[0].name} for {Damage + weapon.effect1 * 2} damage");
        }
        if (characterClass == Class.Mage)
        {
            foreach (MonsterCreate m in Combat.monsterList.ToList()) m.TakeDamage(8 + Spellpower, "");
            Combat.combatText.Add($"Your fireball hits every monster for {8 + Spellpower} damage");
            Combat.combatText.Add("");
        }
    }

    public void BasicAttack(MonsterCreate target)
    {
        int hitRoll = Return.RandomInt(0, 101);
        int critRoll = Return.RandomInt(0, 101);
        if (hitRoll + Hit > 20 + target.defence)
        {
            int dam = (Damage - target.mitigation <= 0) ? 1 : Damage - target.mitigation;
            if (critRoll <= Crit) target.TakeDamage(dam * 2, $"You crit the {target.name} for {dam * 2} damage");
            else target.TakeDamage(dam, $"You hit the {target.name} for {dam} damage");
        }
        else Combat.combatText.Add($"You miss the {target.name}");
        Combat.combatText.Add("");
    }

    public void TakeDamage(int dam, MonsterCreate m, string flavor)
    {
        hp -= dam;
        Combat.combatText.Add(flavor);
        if (hp <= 0) Death(m);
    }

    private void Death()
    {
        Combat.combatText.Add("");
        Combat.combatText.Add("You died!");
    }
    private void Death(MonsterCreate m)
    {
        //You died. Something should happen
    }

    public void Refresh()
    {
        hp = maxHp;
        energy = maxEnergy;
        potion = maxPotion;
        canExplore = true;
    }

    public int Mitigation { get { return mitigation + armor.effect2 + mitigationBonus; } }
    public int Defence { get { return defence + armor.effect1 + defenceBonus; } }
    public int Damage { get { return damage + weapon.effect1 + damageBonus; } }
    public int Hit { get { return hit + weapon.effect2 + hitBonus; } }
    public int Crit { get { return crit + critBonus; } }
    public int Energy { get { return energy + energyBonus; } }
    public int Spellpower { get { return spellPower + spellpowerBonus; } }
}
