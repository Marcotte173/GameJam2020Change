using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class Dungeon
{
    public List<Shell> shell;
    public static Vendor v = new Vendor();
    public Dungeon()
    {
        shell = new List<Shell>
        {
            null,
            new Shell(2,0,0,0,true, new StartRoom()),
            new Shell(3,1,0,24,true, new Room()),
            new Shell(17,2,4,10,true, v),
            new Shell(0,0,5,3,true, new Room()),
            new Shell(6,9,8,4,true, new Room()),

            new Shell(0,5,0,0,true, new Room()),
            new Shell(0,8,0,0,true, new Room()),
            new Shell(7,0,0,5,true, new Room()),
            new Shell(5,0,0,0,true, new Room()),
            new Shell(0,0,3,11,true, new Room()),

            new Shell(12,16,10,0,true, new Room()),
            new Shell(0,11,0,13,true, new Room()),
            new Shell(0,14,12,0,true, new Room()),
            new Shell(13,15,0,0,true, new Room()),
            new Shell(14,0,0,0,true, new Room()),

            new Shell(11,0,0,0,true, new Room()),
            new Shell(18,3,0,0,true, new Room()),
            new Shell(0,17,19,0,true, new Room()),
            new Shell(20,0,0,18,true, new Room()),
            new Shell(0,19,0,21,true, new Room()),

            new Shell(22,0,20,0,true, new Room()),
            new Shell(0,21,23,0,true, new Room()),
            new Shell(0,0,0,22,true, new Room()),
            new Shell(0,0,2,0,true, new BossRoom()),
        };
        int core1Roll = Return.RandomInt(6, 10);
        int core2Roll = Return.RandomInt(13, 17);
        int core3Roll = Return.RandomInt(20, 25);
        shell[core1Roll].room = new Caged();
        shell[core2Roll].room = new Core2();
        shell[core3Roll].room = new Core3();
    }
}