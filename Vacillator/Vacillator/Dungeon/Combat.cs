using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;

public class Combat
{
    public static List<MonsterCreate> monsterList = new List<MonsterCreate> { };
    public static Player player = Program.p;
    public static List<string> combatText = new List<string> { };
    public static int rewardXp;
    public static int rewardGold;
    public static bool boss;

    public static void Start()
    {
        Return.HealthEnergyAdd();
        CombatLoop();
    }
    public static void CombatLoop()
    {
        while (monsterList.Count > 0)
        {
            DisplayCombatText();
            PlayerAttack();
            EnemyAttack();
        }
        Console.Clear();
        Write.Line("You have defeated your enemies!");
        Write.KeyPress();
        if (boss)
        {
            //Go to Zork 
        }
        else
        {
            Console.Clear();
            rewardXp += Return.RandomInt(0, 3);
            rewardGold += Return.RandomInt(0, 25);
            Write.Line($"You find {rewardGold} gold");
            Write.Line($"You gain {rewardXp} experience");
            player.gold += rewardGold;
            player.xp += rewardXp;
            rewardGold = 0;
            rewardXp = 0;
            Write.KeyPress(0, 28);
        }
    }

    public static void DisplayCombatText()
    {
        Info();
        int n = 10;
        for (int i = 0; i < combatText.Count; i++)
        {
            Write.Line(0, n + i, combatText[i]);
        }
        combatText.Clear();
    }

    private static void Info()
    {
        Console.Clear();
        if (monsterList.Count == 3)
        {
            Write.Line(25, 1, "[1] " + monsterList[0].name);
            Write.Line(25, 2, "Health " + monsterList[0].hp + " / " + monsterList[0].maxHp);
            Write.Line(50, 1, "[2] " + monsterList[1].name);
            Write.Line(50, 2, "Health " + monsterList[1].hp + " / " + monsterList[1].maxHp);
            Write.Line(75, 1, "[3] " + monsterList[2].name);
            Write.Line(75, 2, "Health " + monsterList[2].hp + " / " + monsterList[2].maxHp);
        }
        else if (monsterList.Count == 2)
        {
            Write.Line(35, 1, "[1] " + monsterList[0].name);
            Write.Line(35, 2, "Health " + monsterList[0].hp + " / " + monsterList[0].maxHp);
            Write.Line(65, 1, "[2] " + monsterList[1].name);
            Write.Line(65, 2, "Health " + monsterList[1].hp + " / " + monsterList[1].maxHp);
        }
        else
        {
            Write.Line(50, 1, monsterList[0].name);
            Write.Line(50, 2, "Health " + monsterList[0].hp + " / " + monsterList[0].maxHp);
        }
        Return.PlayerInfo();
    }

    private static void PlayerAttack()
    {
        Return.PlayerInfo();
        Write.Line(0, 22, "[1]" + Color.DAMAGE + " Attack   ");
        if (Program.p.characterClass == Class.Adventurer) Write.Line(0, 23, "[X] " + Color.MITIGATION + player.abilityName1);
        else if (Return.HaveEnergy(1)) Write.Line(0, 23, "[2] " + Color.ABILITY + player.abilityName1);
        else Write.Line(0, 23, "[X] " + Color.GREY + "Not enough energy");
        if (Program.p.characterClass == Class.Adventurer) Write.Line(0, 24, "[X] " + Color.MITIGATION + player.abilityName1);
        else if (Program.p.level<3) Write.Line(0, 24, "[X]" + Color.GREY + " Unlocked at Level 3");
        else if (Return.HaveEnergy(2)) Write.Line(0, 24, "[3] " + Color.ABILITY + player.abilityName1);
        else Write.Line(0, 24, "[X] " + Color.GREY + "Not enough energy");
        Write.Line(0, 25, "[X]" + Color.GREY + " Not Implemented");
        if (player.hp != player.maxHp && player.potion > 0) Write.Line(0, 26, "[5] Healing Potion  " + Color.ITEM + player.potion + Color.RESET + " / " + Color.ITEM + player.maxPotion);
        else if (player.potion < 1) Write.Line(0, 26, "[X]" + Color.GREY + " You are out of Healing Potion");
        else Write.Line(0, 26, "[X]" + Color.GREY + " You don't need healing");
        Write.Line(0, 28, "[0] Run");
        string choice = Return.Option();
        if (choice == "1") BasicAttack();
        else if (choice == "2" && Return.HaveEnergy(1)) player.CastAbility1();
        else if (choice == "5" && player.hp != player.maxHp && player.potion > 0)
        {
            int dif = player.maxHp - player.hp;
            int healed;
            if (dif >= player.potion)
            {
                healed = player.potion;
                player.hp += player.potion;
                player.potion = 0;
            }
            else
            {
                player.potion -= dif;
                player.hp = player.maxHp;
                healed = dif;
            }
            combatText.Add($"You drink a potion and heal for {healed}");
            CombatLoop();
        }
        else if (choice == "0")
        {
            Console.Clear();
            Write.Line("Displaying shocking cowardice, you run as fast as you can\n");
            Write.KeyPress();
            Explore.Start();
        }
        else PlayerAttack();

    }

    private static void BasicAttack()
    {
        if (monsterList.Count == 3)
        {
            Write.Line(45, 8, "Select your target");
            string choice = Return.Option();
            if (choice == "1") player.BasicAttack(monsterList[0]);
            else if (choice == "2") player.BasicAttack(monsterList[1]);
            else if (choice == "3") player.BasicAttack(monsterList[2]);
            else BasicAttack();
        }
        else if (monsterList.Count == 2)
        {
            Write.Line(45, 8, "Select your target");
            string choice = Return.Option();
            if (choice == "1") player.BasicAttack(monsterList[0]);
            else if (choice == "2") player.BasicAttack(monsterList[1]);
            else BasicAttack();
        }
        else player.BasicAttack(monsterList[0]);
    }

    private static void EnemyAttack()
    {
        if (monsterList.Count > 0)
            foreach (MonsterCreate m in monsterList) m.BasicAttack();
    }
}