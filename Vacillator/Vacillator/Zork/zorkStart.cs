using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
public class zorkStart : Room
{
   public zorkStart()
   {
       //Sends you to Good ending track
       if (Shock.good && Caged.good && Loot.good) 
       { 
          zorkGoodEnd();
       }
       //Sends you to Neutral ending track
       else if (Shock.good || Caged.good || Loot.good)
       {
         zorkNeutralEnd();
       }
       //Sends you to Bad ending track
       else
       {
         zorkBadEnd();

       }
   }
}
