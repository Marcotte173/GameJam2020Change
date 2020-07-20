using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class Dungeon
{
    public List<Shell> shell;
    public Dungeon()
    {
        shell = new List<Shell>
        {
            null,
            new Shell(2,0,0,0,true, new StartRoom()),
            new Shell(5,1,3,4,true, new Vendor()),
            new Shell(0,0,0,2,true, new Room()),
            new Shell(0,0,2,0,true, new Room()),
            new Shell(0,2,0,0,true, new Room()),
        };
    }
}