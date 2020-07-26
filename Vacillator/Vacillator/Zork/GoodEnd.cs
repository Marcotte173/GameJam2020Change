using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
public class GoodEnd
{
    public static void Start()
    {
        Console.Clear();
        Write.Line(0, 10, "The world around you starts to glitch. Suddenly the memories start coming back to you. This isn't a Manor, nor is this world even real. The realization finally hits you of what’s going on. You need to get out of here…");
        Write.KeyPress();

        Write.Line(0, 13, "You are standing in a metal room. ");
        Write.KeyPress();

        Write.Line(0, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.KeyPress();

        Write.Line(0, 15, "Suddenly you hear a voice reverberate through the room.");
        Write.KeyPress();

        Write.Line(0, 16, "“Ah I see you’ve finally awoken. Nicely done back there by the way, nicely done indeed. No test subject has been able to make it out of that simulation before… at least, not sane that is. Anyways I’ll send the guards to come and escort you, you are no longer of use to us. I would say it was a pleasure working with you but you won’t be alive for very long so my breath is wasted on you. Goodbye” ");
        Write.KeyPress();

        Write.Line("Figure out a way to escape before the guards arrive.");
        Console.ReadKey();

        int check = 0;
        int progress = 0;
        //starts reading inputs
        while (check < 1)
        {
            int controlcheck = 0;
            string zorkCommand = Console.ReadLine();
            bool examine = zorkCommand.Contains("examine");
            bool hit = zorkCommand.Contains("hit");
            bool open = zorkCommand.Contains("open");
            bool enter = zorkCommand.Contains("enter");
            if (examine)
            {
                bool room = zorkCommand.Contains("room");
                bool camera = zorkCommand.Contains("camera");
                bool vent = zorkCommand.Contains("vent");
                if (room)
                {
                    Console.Clear();
                    Write.Line(10, 10, "The room is empty except for a camera. Looking around further reveals a small ventilation system. The screws are rusted, should be easy enough to pull off.. ");
                    Console.ReadKey();
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "That pesky camera... I wonder if i'm strong enough to break it?");
                        Console.ReadKey();
                    }
                    else if (progress > 0)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "With that out of the way the rest should be easy.");
                        Console.ReadKey();
                    }
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 10, "That vent looks to be my only real way out of this place except for the door. But the door wont open untill the guards come.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 10, "I must be halucinating because that object does not exist in this room.");
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
                    Write.Line(10, 10, "As fun as punching the room is. It doesn't seem like a good use of my time.");
                    Console.ReadKey();
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "You punched the camera. Luckily enough you managed to knock it down and it shatters on the floor.");
                        progress++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 10, "The camera is already broken, no need to destroy it further.");
                        Console.ReadKey();
                    }
                }
                else if (vent)
                {
                    Console.Clear();
                    Write.Line(10, 10, "Hitting the vent wont do much but hurt your arms.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 10, "That object doesn't exist here.");
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
                    Write.Line(10, 10, "Can't exactly open a room ya know?");
                    Console.ReadKey();
                }
                else if (camera)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "Opening up that camera wouldn't exactly help much. Breaking it however.....");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 10, "You open the destroyed camera futher. Nothing but random tech in here. Doesn't seem like any of it will work again.");
                        Console.ReadKey();
                    }
                }
                else if (vent)
                {
                    if (progress == 0)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "Can't risk opening this thing while that camera's still working.");
                        Console.ReadKey();
                    }
                    else if (progress == 1)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "You tear the vent lid off. It was simpler than you expected. But you aren’t in the clear yet.");
                        progress++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 10, "It's already open.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 10, "Can't open what doesn't exist.");
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
                    Write.Line(10, 10, "You are already in it.");
                    Console.ReadKey();
                }
                else if (camera)
                {
                    Console.Clear();
                    Write.Line(10, 10, "Something tells you that you won't fit");
                    Console.ReadKey();
                }
                else if (vent)
                {
                    if (progress == 0 || progress == 1)
                    {
                        Console.Clear();
                        Write.Line(10, 10, "Gotta open the thing up first.");
                        Console.ReadKey();
                    }
                    else if (progress == 2)
                    {
                        //only at this point should the game continue to the next section
                        Console.Clear();
                        Write.Line(10, 10, "You entered the vent just in time and crawled through it. No way are those body guards fitting through that. ");
                        check++;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 10, "You shouldn't be here still. This is a bug.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Write.Line(10, 10, "Cant enter something thats not here.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Write.Line("Please Enter A Valid Command");
                Console.ReadKey();
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
        }
        Console.Clear();
        Write.Line("While crawling through the vent you fall through a loose panel. You managed to make it into the control room. In Front of you is a large control board with many screens. Each screen shows you camera footage. You are shocked at what you see. Many, many people in many different simulations. Some are struggling, some aren't. As you watch you notice that some of the cameras go out suddenly. Only to turn right back on, but ith someone else at the center of it now. There is only one explanation, and it's not a fond one to think about.");
        Write.KeyPress();

        Write.Line(0, 17, "On the control panel there are many buttons but one of them stands out the most. It’s an emergency shutdown switch. Pushing it will free all the captives. This laboratory will be taken over by the very test subjects that they held here, and the cruelty would end, but you might not be joining them in this escape, you can hear guards just outside the door, pushing it will surely alert them. However you could also just leave now. On your own back through that vent into the outside world. What will you do?");
        Console.ReadKey();
        Console.Clear();
        while (check < 2)
        {
            string zorkCommand = Console.ReadLine();
            bool pushed = zorkCommand.Contains("push button");
            bool notPushed = zorkCommand.Contains("don't push button");
            if (pushed)
            {
                Write.Line("As you push the button you hear alarms start blaring outside and on the screen you can see all the simulations ending and people starting to make their ways into the halls. The guards barge in to see what’s going on and grab you. As they begin to pull you away multiple escapees jump them from behind and knock them out. After a long while of fighting your way through guards with your new companions you all find your way out of the facility and escape!");
                Console.ReadKey();
                Console.Clear();
                Write.Line(0, 20, "Congratulations, you got the ending - Everyone’s Savior!");
                check++;
                //Add code to unlock class or whatever is intended
            }
            else if (notPushed)
            {
                Write.Line(0, 17,"You against pushing the button as its too risky for yourself, You climb back up into the vents and after some time find a path leading out of the facility. As you fall out of the vent and onto the grass outside, you run into the forests and far far away. Never looking back.");
                Console.ReadKey();
                Console.Clear();
                Write.Line(0, 18,"Congratulations, you got the ending - Free once more!");
                check++;
                //Add code to unlock class or whatever is intended
            }
            else
            {
                Write.Line(0,20,"There's only 2 choices here. Push or Don't");
            }
        }
        GameJam2020Change.Program.Start();
    }
}






