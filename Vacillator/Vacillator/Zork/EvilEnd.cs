using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
public class zorkEvilEnd
{
    public zorkEvilEnd()
    {
        Console.Clear();
        Write.Line(0, 10, "The world around you starts to glitch. Suddenly the memories start coming back to you. This isn't a Manor, nor is this world even real. But in reality. Who really cares? A kill is a kill no matter what world it’s in. And people are so much easier to dispose of than monsters.");
        Write.KeyPress();

        Write.Line(0, 13, "You are standing in a metal room. ");
        Write.Line(0, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(0, 15, "Suddenly you hear a voice reverberate through the room.");
        Write.Line(0, 16, "“Ah I see you’ve finally awoken.”");
        Write.Line(0, 17, "But, before the voice gets another word in you cut them off.");
        Write.Line(0, 18, "“Let’s cut the formalities shall we? We both know what you plan to do with me now. And we both know you aren’t planning on letting me out of here alive.”");
        Write.Line(0, 19, "The voice responds, tho sounding a lot more aggressive than before. “Ah so you are aware of your position, well how about this, you go with the guards like a good little test subject. And we won't have to get rough with you. Deal?”");
        Write.Line(0, 21, "You just sit there and chuckle at the absurdity. Heh, going quietly. Oh no, if you are going down, you are taking as many as you can with you!");
        Write.KeyPress();
        Write.Line(10, 24, "Find a weapon or use your hands =)");
        Console.ReadKey();

        int check = 0;
        bool weapon = false;

        //starts reading inputs
        while (check < 1)
        {
            string zorkCommand = Console.ReadLine();
            bool examine = zorkCommand.Contains("examine");
            bool hit = zorkCommand.Contains("hit");
            bool open = zorkCommand.Contains("open");
            bool enter = zorkCommand.Contains("enter");
            bool fists = zorkCommand.Contains("hands");
            int progress = 0;
            if (examine)
            {
                bool room = zorkCommand.Contains("room");
                bool camera = zorkCommand.Contains("camera");
                bool vent = zorkCommand.Contains("vent");
                if (room)
                {
                    Console.Clear();
                    Write.Line(10, 0, "The room is empty except for a camera. Looking around further reveals a small ventilation system. The screws are rusted, should be easy enough to pull off. Rusty screws make for such good weapons, don’t you think? =)");
                    Console.ReadKey();   
                }
                else if (camera)
                {
                    Console.Clear();
                    Write.Line(10, 0, "I wonder who's behind it? =)");
                    Console.ReadKey();      
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 0, "The cover is held in place by some rusty screws. They'd make for good weapons =)");
                    Console.ReadKey();    
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 0, "I must be halucinating because that object does not exist in this room.");
                    Console.ReadKey();     
                }
            }
            else if (hit)
            {
                bool room = zorkCommand.Contains("room");
                bool camera = zorkCommand.Contains("camera");
                bool vent = zorkCommand.Contains("vent");
                if (room)
                {
                    Console.Clear();
                    Write.Line(10, 0, "As fun as punching the room is. It doesn't seem like a good use of my time.");
                    Console.ReadKey();
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 0, "Hitting the camera caused it to fall to the ground and shatter, aggravating the one behind it further. Human emotions can be so easy to manipulate =)");
                        progress++;
                        Console.ReadKey(); 
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 0, "The camera is already broken. It's parts are useless to me.");
                        Console.ReadKey();     
                    }
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 0, "Hitting the vent wont do much but hurt your arms.");
                    Console.ReadKey();        
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 0, "That object doesn't exist here.");
                    Console.ReadKey();
                }
            }
            else if (open)
            {
                bool room = zorkCommand.Contains("room");
                bool camera = zorkCommand.Contains("camera");
                bool vent = zorkCommand.Contains("vent");
                if (room)
                {
                    Console.Clear();
                    Write.Line(10, 0, "Can't exactly open a room ya know?");
                    Console.ReadKey();
               
                      
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 0, "Opening up that camera wouldn't exactly help much.");
                        Console.ReadKey();
                       
                          
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 0, "You open the destroyed camera futher. Nothing but random tech in here. Doesn't seem like any of it will work again.");
                        Console.ReadKey();
                    
                          
                    }
                }
                else if (vent)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 0, "You tear the vent lid off and take out the screws to use as a weapon. The camera is still watching you but the one behind it has become even more pissed off. Is that fear in their voice? =)");
                        Console.ReadKey();
                     
                        progress += 2;
                        weapon = true;
                        
                    }
                    else if (progress == 1)
                    {
                        Console.Clear();
                        Write.Line(10, 0, "You tear the vent lid off and take out the screws to use as a weapon.");
                        Console.ReadKey();
                        progress++;
                        weapon = true;
                       
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 0, "It's already open.");
                        Console.ReadKey();
            
                        
                    }
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 0, "Can't open what doesn't exist.");
                    Console.ReadKey();
              
                }
            }
            else if (enter)
            {
                bool room = zorkCommand.Contains("room");
                bool camera = zorkCommand.Contains("camera");
                bool vent = zorkCommand.Contains("vent");
                if (room)
                {
                    Console.Clear();
                    Write.Line(10, 0, "You are already in it.");
                    Console.ReadKey();
             
               
                }
                else if (camera)
                {
                    Console.Clear();
                    Write.Line(10, 0, "Something tells you that you won't fit");
                    Console.ReadKey();
             
                 
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 0, "Now, Why would I want to run from such a perfect situation?");
                    Console.ReadKey();
                    
                    
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 0, "Cant enter something thats not here.");
                    Console.ReadKey();

                   
                }
            }
            else
            {
                Console.Clear();
                Write.Line("Please Enter A Valid Command");
                Console.ReadKey();
                int controlcheck = 0;
                while (controlcheck < 1)
                {
                    if (zorkCommand != "")
                    {
                        Write.Line(zorkCommand);
                        controlcheck++;
                    }
                    else
                    {
                        Write.Line("Empty");
                        controlcheck++;
                    }
                }
            }
            if (fists)
            {
                Console.Clear();
                Write.Line(0, 0,"The guards enter the room to try grab you and take you away. But you aren’t going down without a fight! You manage to snap the neck of the first guard and knock out the other one with a strong punch to the gut, before making a break for it. As you continue to run down the halls, and being chased by an ever increasing number of guards you are finally caught in a dead end. You turn around to try and fight them off but there are too many of them to handle. You are quickly subdued and terminated on the spot.");
                Write.KeyPress();
                Write.Line(0, 10, "Congratulations you. . . not enough blood. You worthless runner!");
                Write.KeyPress();
                Environment.Exit(1);
            }
            else if (weapon)
            {
                check++;
            }
        }
        Console.Clear();
        Write.Line(0,1,"Ah here come the guards. I wonder just how many I’ll get to kill =)");
        Write.KeyPress();

        Write.Line(0, 2, "The first 2 guards enter the room to try and capture you. That's 2 dead =)");
        Write.KeyPress();

        Write.Line(0, 3, "You exit the containment area, sirens blaring all around you as guards are coming from all sides. It will take more than a few guards to get rid of me. hah. hahaha. Hahahaha. hahaHAHAHAAHAHA!");
        Write.KeyPress();

        Write.Line(0, 5, "You fight your way through the hordes of guards. Brutally murdering each and every guard that dares stand in your way until you reach the command room. This is where the one in charge of the facility is hiding. Such a fool to believe I won't make it to them as well.");
        Write.KeyPress();
        
        Write.Line(0, 8, "You burst through the door and proceed to pin them to the wall.");
        Write.KeyPress();
        
        Write.Line(0, 9, "SAY GOODBYE YOU PATHETIC FOOL!");
        Write.KeyPress();
        
        Write.Line(0, 10, "As you slit the throat of their leader. You feel a sharp pain in your back. You’ve been shot, but before you can do much else 3 more shots ring out, the final bullet hitting you in the head, killing you on the spot.");
        Write.KeyPress();
        
        Write.Line(0, 15, "Congratulations! You got the ending - Burning in hell!");
        
        Write.KeyPress();
        GameJam2020Change.Program.Start();
    }
}
