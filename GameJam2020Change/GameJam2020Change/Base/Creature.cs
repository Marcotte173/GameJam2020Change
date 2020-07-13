using System;
using System.Collections.Generic;
using System.Text;

public class Creature
{
    public int hp;
    public int maxHp;
    public int energy;
    public int maxEnergy;
    public int hit;
    public int defence;
    public int crit;
    public int spellpower;
    public int damage;
    public int mitigation;
    public string type;
    public List<string> text;
    public Creature target;

    public Creature()
    {

    }

    public void Heal(int heal)
    {
        hp = (hp + heal >= maxHp) ? maxHp : hp + heal;
    }

    public void TakeDamage(int dam)
    {
        hp = (hp - dam <= 0) ? 0 : hp - dam;
        if (hp == 0) Death();
    }

    public virtual void Death()
    {
        
    }
}