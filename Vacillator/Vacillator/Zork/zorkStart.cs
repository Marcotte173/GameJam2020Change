using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
public class zorkStart : Room
{
   public zorkStart()
   {
        if (Explore.d.shell[Explore.d.core1Roll].room.visited && Explore.d.shell[Explore.d.core2Roll].room.visited && Explore.d.shell[Explore.d.core3Roll].room.visited)
        {
            //Sends you to Good ending track
            if (Explore.d.shell[Explore.d.core1Roll].room.good && Explore.d.shell[Explore.d.core2Roll].room.good && Explore.d.shell[Explore.d.core3Roll].room.good)
            {
                new zorkGoodEnd();
            }
            //Sends you to Neutral ending track
            else if (Explore.d.shell[Explore.d.core1Roll].room.good || Explore.d.shell[Explore.d.core2Roll].room.good || Explore.d.shell[Explore.d.core3Roll].room.good)
            {
                new zorkNeutralEnd();
            }
            //Sends you to Bad ending track
            else
            {
                new zorkEvilEnd();

            }
        }
        else
        {
            Explore.Start();
        }
   }
}
