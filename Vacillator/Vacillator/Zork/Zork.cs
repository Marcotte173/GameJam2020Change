using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
public class Zork
{
   public static void Start()
   {
        //Sends you to Good ending track
        if (Explore.d.shell[Explore.d.core1Roll].room.good && Explore.d.shell[Explore.d.core2Roll].room.good && Explore.d.shell[Explore.d.core3Roll].room.good)
        {
            GoodEnd.Start();
        }
        //Sends you to Neutral ending track
        else if (Explore.d.shell[Explore.d.core1Roll].room.good || Explore.d.shell[Explore.d.core2Roll].room.good || Explore.d.shell[Explore.d.core3Roll].room.good)
        {
            NeutralEnd.Start();
        }
        //Sends you to Bad ending track
        else
        {
            EvilEnd.Start();
        }
    }
}
