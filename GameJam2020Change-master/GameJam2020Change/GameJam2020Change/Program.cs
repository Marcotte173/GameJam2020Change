using System;
using System.ComponentModel;

namespace GameJam2020Change
{
    class Program
    {
        public static Player p = new Player();
        public static string name;
        static void Main(string[] args)
        {
            Color.SetupConsole();
            Console.CursorVisible = false;
            Write.Line(Color.HEALTH,40,6," _   _            _ _ _       _              ");
            Write.Line(Color.HEALTH,40,7,"| | | |          (_) | |     | |             ");
            Write.Line(Color.HEALTH,40,8,"| | | | __ _  ___ _| | | __ _| |_ ___  _ __  ");
            Write.Line(Color.HEALTH,40,9,"| | | |/ _` |/ __| | | |/ _` | __/ _ \\| '__| ");
            Write.Line(Color.HEALTH,40,10,"\\ \\_/ / (_| | (__| | | | (_| | || (_) | |    ");
            Write.Line(Color.HEALTH,40,11," \\___/ \\__,_|\\___|_|_|_|\\__,_|\\__\\___/|_|    ");
            Write.Line(100, 26, "Version 0.01");
            Write.KeyPress();
            Story();
            Start();
        }

        private static void Story()
        {
            Console.Clear();
            Write.Line("\n\nYou stand, feet planted, at the foot of a cave,\na cavern,\na DUNGEON.\n\n");
            Write.Line("You stand ready to enter the legendary Dungeon of Vacillator, \nwhose depth promise those who enter Knowledge, Power, and Salvation. \nThe Dungeon calls out to those it deems worthy.");
            Write.KeyPress();
        }

        public static void Start()
        {
            Console.Clear();
            Write.Line("The halls and holes call YOUR name from deep within. What name do they call?\n");
            name = Return.String();
            Console.WriteLine();
            if (Return.Confirm(name)) CharacterClass();
            else Start();
        }

        private static void CharacterClass()
        {
            Console.Clear();            
            Write.Line($"{name}, Your eyes are steady, facing down your future, but there is a spark deep within your gaze. The spark of...\n");
            Write.Line("[1] You have no real background. This is terrible writing, but will be replaced by something cool that Spencer writes. \nYou get an adventurer.\n");
            if (Manager.mage)    Write.Line(Color.ABILITY, "[2] Flavor to follow. You get a Mage\n");
            if (Manager.rogue)   Write.Line(Color.ABILITY, "[3] Flavor to follow. You get a Rogue\n");
            if (Manager.warrior) Write.Line(Color.ABILITY, "[4] Flavor to follow. You get a Warrior\n");
            string choice = Return.Option();
            if (choice == "1") p = new Player(Class.None);
            else if (choice == "2" && Manager.mage) p = new Player(Class.Mage);
            else if (choice == "3" && Manager.rogue) p = new Player(Class.Rogue);
            else if (choice == "4" && Manager.warrior) p = new Player(Class.Warrior);
            else CharacterClass();
            p.name = name;
            Flavor();
            Explore.currentShell = Explore.d.shell[1];
            Explore.Start();
        }

        private static void Flavor()
        {
            Console.Clear();
            Write.Line("Some delicious fravor fresh from Spencer's brain.");
            Write.KeyPress();
        }

        private static void Work()
        {
            Console.Clear();
            Write.Line($"Name: {p.name}");
            Write.Line($"Class: {p.characterClass}");
            Write.Line($"\nHealth: {p.hp}/{p.maxHp }");
            Write.Line($"Energy: {p.energy}/{p.maxEnergy}");
            Write.Line($"Damage: {p.damage}");
            Write.Line($"Hit: {p.hit}");
            Write.Line($"Crit: {p.crit}");
            Write.Line($"Defence: {p.defence}");
            Write.Line($"Mitigation: {p.mitigation}");
            Write.Line($"Gold: {p.gold}");
            Console.ReadKey();
        }

    }
}