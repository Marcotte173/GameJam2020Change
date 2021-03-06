﻿using System;
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
            Sound.PlayOnce("town");
            Console.CursorVisible = false;
            Write.Line(Color.HEALTH, 40, 6, " _   _            _ _ _       _              ");
            Write.Line(Color.HEALTH, 40, 7, "| | | |          (_) | |     | |             ");
            Write.Line(Color.HEALTH, 40, 8, "| | | | __ _  ___ _| | | __ _| |_ ___  _ __  ");
            Write.Line(Color.HEALTH, 40, 9, "| | | |/ _` |/ __| | | |/ _` | __/ _ \\| '__| ");
            Write.Line(Color.HEALTH, 40, 10, "\\ \\_/ / (_| | (__| | | | (_| | || (_) | |    ");
            Write.Line(Color.HEALTH, 40, 11, " \\___/ \\__,_|\\___|_|_|_|\\__,_|\\__\\___/|_|    ");
            Write.Line(100, 26, "Version 0.01");
            Write.KeyPress();
            NeutralEnd.Start();
            Story();
            Start();
        }

        private static void Story()
        {
            Console.Clear();
            Sound.Stop();
            Write.Line("\n\nYou stand, feet planted, at the foot of a cave,\na cavern,\na DUNGEON.\n\n");
            Write.Line("You stand ready to enter the legendary Dungeon of Vacillator, \nwhose depth promise those who enter Knowledge, Power, and Salvation. \nThe Dungeon calls out to those it deems worthy.");
            Write.KeyPress();
        }

        public static void Start()
        {
            Console.Clear();
            Write.Line("The halls and holes call YOUR name from deep within. What name do they call?\n\n\n");
            Console.WriteLine(Color.NAME);
            name = Return.String();
            Console.WriteLine(Color.RESET);
            if (name != "")
            {
                if (Return.Confirm("\n\nYour name is " + Color.NAME + name +  Color.RESET + "?\n\n")) CharacterClass();
                else Start();
            }
            else Start();
        }

        private static void CharacterClass()
        {
            Console.Clear();
            Write.Line($"{name}, Your eyes are steady, facing down your future, but there is a spark deep within your gaze. The spark of...\n");
            Write.Line("[1] The " + Color.ENERGY + "Arcane" + Color.RESET + "\n\nThis is terrible writing, but will be replaced by something cool that Spencer writes. \nYou get an " + Color.ABILITY + "Mage.\n");
            Write.Line("[2] The " + Color.BLOOD + "Hidden" + Color.RESET + "\n\nThis is terrible writing, but will be replaced by something cool that Spencer writes. \nYou get an " + Color.ABILITY + "Rogue.\n");
            Write.Line("[3] The " + Color.MITIGATION+"Watchful"+Color.RESET+"\n\nThis is terrible writing, but will be replaced by something cool that Spencer writes. \nYou get an " + Color.ABILITY + "Warrior.\n");
            string choice = Return.Option();
            if (choice == "1") p = new Player(Class.Mage);
            else if (choice == "2") p = new Player(Class.Rogue);
            else if (choice == "3") p = new Player(Class.Warrior);
            else CharacterClass();
            p.name = name;
            Explore.currentShell = Explore.d.shell[1];
            Return.NameAdd();
            Manager.Vendor();
            Explore.Start();
        }
    }
}