using System;

namespace GameJam2020Change
{
    class Program
    {
        public static Player p = new Player();
        static void Main(string[] args)
        {
            Color.SetupConsole();
            Write.Line(Color.RED,"Hello");
            Write.Line(Color.BLUE, 6,4,"Now");
            Write.Line(Color.GREEN,14,6,"I");
            Write.Line(Color.RED,20,15,"Can");
            Write.Line(Color.YELLOW,29,10,"Write");
            Write.Line(Color.RED,36,6,"All");
            Write.Line(Color.BLUE," Over");
            Write.Line(Color.RED," The");
            Write.Line(Color.GREEN," Place");
            Console.ReadKey();
            Test();
        }

        public static void Test()
        {
            Write.Line("What is your name?");
            string name = Return.Option();

            
        }
    }
}
