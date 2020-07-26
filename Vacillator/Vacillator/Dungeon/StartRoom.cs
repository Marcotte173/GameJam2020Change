using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class StartRoom:Room
{    
    public StartRoom()
    { 
        visitedFlavor = "You enter the first room you found in the manor. A pile of bones lay crubled on the ground.\nIt feels like you are walking in circles." ;
        name = "Room with a pile of bones"; 
    }
    internal override void ExploreRoom()
    {
        Console.Clear();
        if (visited) Write.Line(visitedFlavor);
        else 
        {
            Write.Line(10,10,"You reach your hand to the heavy handle of the manor. The doors swing open with a hefty and howling squeak.");
            Write.Line(10,11,"It is too late to turn back");
            Write.KeyPress();
            
            Write.Line(10,13,"Those heavy doors slam shut behind you, giving you only one way to go, deeper into the estate.");
            Write.Line(10,14,"Now, Your fate has been sealed into the halls of Vacillator!");
            
            Write.KeyPress();
            Console.Clear();

            Write.Line(10,10,"The front room is dark and damp with the fermenting scent of the building’s age hanging in the air.");
            Write.Line(10,11,"You press forward to the first room. It opens into a great but empty hall.");
            Write.Line(10,12,"All that exists in it is a jumbled pile of dust and bones.");
            Write.Line(10,13,"The only distinguishing feature of the pile is the skull that rests firmly on the top facing right towards you.");
            Write.Line(10,14,"Clenched firmly in the skull’s mouth seems to be a ring of tough iron keys,");
            Write.Line(10,15,"each one jammed between the teeth in its maw.");
            Write.KeyPress();
            Write.Line(10,17,"The room has quite a tall ceiling with many paintings lining the 8 walls of the octagonal room,");
            Write.Line(10,18,"but besides that, the room has one other door across from you. It seems to have a huge lock on it");
            Write.Line(50,20, "what do you do?");
            Write.Line(50,23, "[get the keys]");
            Write.KeyPress();
            Console.Clear();
            Write.Line(10,8,"You approach the skull and the pile of bones,");
            Write.Line(10,9,"the age of which seems like it could be older than the entire building itself.");
            Write.Line(10,10,"Your hand reaches for the hoop of iron, and when your only inches away, ");
            Write.Line(10,11,"a spark of static jumps from your fingers to the ring.");
            Write.Line(10,12,"You jump back and feel as if your heart had skipped its last beat in order to produce the shock itself.");
            Write.KeyPress();
            Write.Line(10,14,"Then, LIFE. The spark from your hand dances across the ring and through the skull of around it.");
            Write.Line(10,15,"It zapped throughout the pile of bones. ");
            Write.Line(10,16,"The keys on the ring began to float and twitch with a charge that demanded attention,");
            Write.Line(10,17,"so you unsheathed your weapon and held your stance.");
            Write.KeyPress();
            Write.Line(10,19,"The pile pulls itself together and forms a body that is almost human-shaped.");
            Write.Line(10,20,"The bones all not quite in the right place or position. ");
            Write.Line(10,21,"Its eyes and key teeth sparked and shuddered with power.");
            Write.Line(10,22,"And then, the power approached YOU");
            Write.Line(50,24,"[Prepare for combat!]");
            Write.KeyPress();
            //Combat(x)
            Console.Clear();
            Write.Line(10,10,"You follow through with your final movement and take down the creature with swift execution.");
            Write.Line(10,11,"The skull’s mouth unhinging and releasing the set of keys it bore so tightly in its jaws.");
            Write.Line(10,12,"You gained a keyring!");
            for(int i = 0; i < 14; i++)
            {
                
                if(i == 0 )
                {
                    Write.Line(40,23,"[keyring added to inventory]");
                }
                else if(i == 4 )
                {
                    Write.Line(40,23,"[keyring " + Color.ITEM + "a" + Color.RESET + "dded to inventory]");
                    Sound.PlayOnce("complexbeep");
                }
                else if(i ==6 )
                {
                    Write.Line(40,23,"[keyring " + Color.ITEM + "a" + Color.RESET + "dded to in" + Color.ITEM + "v" + Color.RESET + "entory]");
                    Sound.PlayOnce("complexbeep");
                }
                else if(i ==9 )
                {
                    Write.Line(40,23,"[keyrin" + Color.ITEM + "g a" + Color.RESET + "dded to in" + Color.ITEM + "v" + Color.RESET + "ent" + Color.ITEM + "or" + Color.RESET + "y]");
                    Sound.PlayOnce("complexbeep");
                }
                else if(i ==11 )
                {
                    Write.Line(40,23,"[" + Color.ITEM + "ke" + Color.RESET + "yri" + Color.ITEM + "ng add" + Color.RESET + "ed to i" + Color.ITEM + "nv" + Color.RESET + "en" + Color.ITEM + "tory" + Color.RESET + "]");
                    Sound.PlayOnce("complexbeep");
                }
                Thread.Sleep(300);

            }

            Write.Line(40, 23, "[" + Color.ITEM + "keyring added to inventory" + Color.RESET + "]");
            Sound.PlayOnce("complexbeep");
            Write.KeyPress();
            Sound.PlayOnce("confirm");

            Return.ClassAdd();

            visited = true;
        }        
    }
}
