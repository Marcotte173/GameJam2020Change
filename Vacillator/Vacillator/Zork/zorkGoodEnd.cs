using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
public class zorkGoodEnd
{
    public zorkGoodEnd()
    {
        Write.Line(10, 10, "The world around you starts to glitch. Suddenly the memories start coming back to you. This isn't a Manor, nor is this world even real. The realization finally hits you of what’s going on. You need to get out of here…");
        Write.KeyPress();

        Write.Line(10, 13, "You are standing in a metal room. ");
        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(10, 15, "Suddenly you hear a voice reverberate through the room.");
        Write.Line(10, 16, "“Ah I see you’ve finally awoken. Nicely done back there by the way, nicely done indeed. No test subject has been able to make it out of that simulation before… at least, not sane that is. Anyways I’ll send the guards to come and escort you, you are no longer of use to us. I would say it was a pleasure working with you but you won’t be alive for very long so my breath is wasted on you. Goodbye” ");
        Write.KeyPress();

        Write.Line(10, 17, "Figure out a way to escape before the guards arrive.");

        int check = 0;
        string zorkCommand = Console.ReadLine();

        //starts reading inputs
        while (check < 1)
        {
            bool examine = zorkCommand.Contains("examine");
            bool hit = zorkCommand.Contains("hit");
            bool open = zorkCommand.Contains("open");
            bool enter = zorkCommand.Contains("enter");
            int progress = 0;
            if (examine)
            {
                bool room = zorkCommand.Contains("room");
                bool camera = zorkCommand.Contains("camera");
                bool vent = zorkCommand.Contains("vent");
                if (room) 
                {
                    Console.Clear();
                    Write.Line(10, 25, "The room is empty except for a camera. Looking around further reveals a small ventilation system. The screws are rusted, should be easy enough to pull off.. ");
                    Write.KeyPress();
                }
                else if (camera)
                {
                    Console.Clear();
                    Write.Line(10, 25, "That pesky camera... I wonder if i'm strong enough to break it?");
                    Write.KeyPress();
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 25, "That vent looks to be my only real way out of this place except for the door. But the door wont open untill the guards come.");
                    Write.KeyPress();
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 25, "I must be halucinating because that object does not exist in this room.");
                    Write.KeyPress();
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
                    Write.Line(10, 25, "As fun as punching the room is. It doesn't seem like a good use of my time.");
                    Write.KeyPress();
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "You punched the camera. Luckily enough you managed to knock it down and it shatters on the floor.");
                        progress++;
                        Write.KeyPress();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 25, "The camera is already broken, no need to destroy it further.");
                        Write.KeyPress();
                    }
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 25, "Hitting the vent wont do much but hurt your arms.");
                    Write.KeyPress();
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 25, "That object doesn't exist here.");
                    Write.KeyPress();
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
                    Write.Line(10, 25, "Can't exactly open a room ya know?");
                    Write.KeyPress();
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "Opening up that camera wouldn't exactly help much. Breaking it however.....");
                        Write.KeyPress();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 25, "You open the destroyed camera futher. Nothing but random tech in here. Doesn't seem like any of it will work again.");
                        Write.KeyPress();
                    }
                }
                else if (vent)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "Can't risk opening this thing while that camera's still working.");
                        Write.KeyPress();
                    }
                    else if (progress == 1)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "You tear the vent lid off. It was simpler than you expected. But you aren’t in the clear yet.");
                        progress++;
                        Write.KeyPress();
                    }
                    else 
                    {
                        Console.Clear();
                        Write.Line(10, 25, "It's already open.");
                        Write.KeyPress();
                    }
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 25, "Can't open what doesn't exist.");
                    Write.KeyPress();
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
                    Write.Line(10, 25, "You are already in it.");
                    Write.KeyPress();
                }
                else if (camera)
                {
                    Console.Clear();
                    Write.Line(10, 25, "Something tells you that you won't fit");
                    Write.KeyPress();
                }
                else if (vent)
                {
                    if (progress == 0 || progress == 1)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "Gotta open the thing up first.");
                        Write.KeyPress();
                    }
                    else if (progress == 2)
                    {
                        //only at this point should the game continue to the next section
                        Console.Clear();
                        Write.Line(10, 25, "You entered the vent just in time and crawled through it. No way are those body guards fitting through that. ");
                        check++;
                        Write.KeyPress();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 25, "You shouldn't be here still. This is a bug.");
                        Write.KeyPress();
                    }
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 25, "Cant enter something thats not here.");
                    Write.KeyPress();
                }
            }
        }
        Console.Clear();
        Write.Line("While crawling through the vent you fall through a loose panel. You managed to make it into the control room. In Front of you is a large control board with many screens. Each screen shows you camera footage. You are shocked at what you see. Many, many people in many different simulations. Some are struggling, some aren't. As you watch you notice that some of the cameras go out suddenly. Only to turn right back on, but ith someone else at the center of it now. There is only one explanation, and it's not a fond one to think about.");
        Write.KeyPress();

        Write.Line("On the control panel there are many buttons but one of them stands out the most. It’s an emergency shutdown switch. Pushing it will free all the captives. This laboratory will be taken over by the very test subjects that they held here, and the cruelty would end, but you might not be joining them in this escape, you can hear guards just outside the door, pushing it will surely alert them. However you could also just leave now. On your own back through that vent into the outside world. What will you do?");
        Write.KeyPress();
        while (check < 2)
        {
            bool pushed = zorkCommand.Contains("push button");
            bool notPushed = zorkCommand.Contains("don't push button");
            if (pushed)
            {
                Write.Line("As you push the button you hear alarms start blaring outside and on the screen you can see all the simulations ending and people starting to make their ways into the halls. The guards barge in to see what’s going on and grab you. As they begin to pull you away multiple escapees jump them from behind and knock them out. After a long while of fighting your way through guards with your new companions you all find your way out of the facility and escape!");
                Write.KeyPress();
                Console.Clear();
                Write.Line("Congratulations, you got the ending - Everyone’s Savior!");
                check++;
                //Add code to unlock class or whatever is intended
            }
            else if (notPushed)
            {
                Write.Line("You against pushing the button as its too risky for yourself, You climb back up into the vents and after some time find a path leading out of the facility. As you fall out of the vent and onto the grass outside, you run into the forests and far far away. Never looking back.");
                Write.KeyPress();
                Console.Clear();
                Write.Line("Congratulations, you got the ending - Free once more!");
                check++;
                //Add code to unlock class or whatever is intended
            }
            else
            {
                Write.Line("There's only 2 choices here. Push or Don't");
                Write.KeyPress();
            }
        }
        GameJam2020Change.Program.Start();
    }
}



