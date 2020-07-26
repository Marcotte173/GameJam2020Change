public class MonsterCreate : Creature
{
    public string summon;
    public bool boss;
    public MonsterCreate()
    : base()
    {

    }
    public void TakeDamage(int dam, string flavor)
    {
        hp -= dam;
        Combat.combatText.Add(flavor);
        if (hp <= 0) Death();
    }

    void Death()
    {
        Combat.combatText.Add("");
        Combat.combatText.Add($"You killed the {name}!");
        Combat.monsterList.Remove(this);
        Combat.rewardGold += gold;
        Combat.rewardXp += xp;
        if (boss) Combat.boss = true;
    }

    public void BasicAttack()
    {
        int hitRoll = Return.RandomInt(0, 101);
        int critRoll = Return.RandomInt(0, 101);
        if (hitRoll + hit > 20 + GameJam2020Change.Program.p.defence)
        {
            int dam = (damage - GameJam2020Change.Program.p.mitigation <= 0) ? 1 : damage - GameJam2020Change.Program.p.mitigation;
            if (critRoll <= crit) GameJam2020Change.Program.p.TakeDamage(dam * 2, this, $"The {name} crits you for {dam * 2} damage");
            else GameJam2020Change.Program.p.TakeDamage(dam, this, $"The {name} hits you for {dam} damage");
        }
        else Combat.combatText.Add($"The {name} misses you");
    }

    public MonsterCreate Copy()
    {
        return (MonsterCreate)MemberwiseClone();
    }
}
