using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
public class NeutralEnd
{
    public static void Start()
    {
        Write.Line(10, 10, "The world around you starts to glitch. Suddenly the memories start coming back to you. This isn't a Manor, nor is this world even real. The realization finally hits you of what’s going on. You need to get out of here…");
        Write.KeyPress();

        Write.Line(10, 13, "You are standing in a metal room. ");
        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(10, 15, "Suddenly you hear a voice reverberate through the room.");
        Write.Line(10, 16, "“Ah I see you’ve finally awoken. Nicely done back there by the way, nicely done indeed. No test subject has been able to make it out of that simulation before… at least, not sane that is. Anyways I’ll send the guards to come and escort you, you are no longer of use to us. I would say it was a pleasure working with you but you won’t be alive for very long so my breath is wasted on you. Goodbye” ");
        Write.KeyPress();

        Write.Line(10, 17, "You have 5 turns. Figure out a way to escape before the guards arrive.");

        int turns = 5;
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
            if (turns > 0)
            {
                if (examine)
                {
                    bool room = zorkCommand.Contains("room");
                    bool camera = zorkCommand.Contains("camera");
                    bool vent = zorkCommand.Contains("vent");
                    if (room)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "The room is empty except for a camera. Looking around further reveals a small ventilation system. The screws are rusted, should be easy enough to pull off.. ");
                        turns--;
                        Write.KeyPress();
                    }
                    else if (camera)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "That pesky camera... I wonder if i'm strong enough to break it?");
                        turns--;
                        Write.KeyPress();
                    }
                    else if (vent)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "That vent looks to be my only real way out of this place except for the door. But the door wont open untill the guards come.");
                        turns--;
                        Write.KeyPress();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 25, "I must be halucinating because that object does not exist in this room.");
                        turns--;
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
                        turns--;
                        Write.KeyPress();
                    }
                    else if (camera)
                    {
                        if (progress == 0)
                        {
                            Console.Clear();
                            Write.Line(10, 25, "You punched the camera. Luckily enough you managed to knock it down and it shatters on the floor. Unluckily however the one behind it hurries the guards.");
                            progress++;
                            turns -= 2;
                            Write.KeyPress();
                        }
                        else
                        {
                            Console.Clear();
                            Write.Line(10, 25, "The camera is already broken, no need to destroy it further.");
                            turns--;
                            Write.KeyPress();
                        }
                    }
                    else if (vent)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "Hitting the vent wont do much but hurt your arms.");
                        turns--;
                        Write.KeyPress();
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 25, "That object doesn't exist here.");
                        turns--;
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
                        turns--;
                        Write.KeyPress();
                    }
                    else if (camera)
                    {
                        if (progress == 0)
                        {
                            Console.Clear();
                            Write.Line(10, 25, "Opening up that camera wouldn't exactly help much. Breaking it however.....");
                            turns--;
                            Write.KeyPress();
                        }
                        else
                        {
                            Console.Clear();
                            Write.Line(10, 25, "You open the destroyed camera futher. Nothing but random tech in here. Doesn't seem like any of it will work again.");
                            turns--;
                            Write.KeyPress();
                        }
                    }
                    else if (vent)
                    {
                        if (progress == 0)
                        {
                            Console.Clear();
                            Write.Line(10, 25, "Can't risk opening this thing while that camera's still working.");
                            turns--;
                            Write.KeyPress();
                        }
                        else if (progress == 1)
                        {
                            Console.Clear();
                            Write.Line(10, 25, "You tear the vent lid off. It was simpler than you expected. But you aren’t in the clear yet.");
                            progress++;
                            turns--;
                            Write.KeyPress();
                        }
                        else
                        {
                            Console.Clear();
                            Write.Line(10, 25, "It's already open.");
                            turns--;
                            Write.KeyPress();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Write.Line(10, 25, "Can't open what doesn't exist.");
                        turns--;
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
                        turns--;
                        Write.KeyPress();
                    }
                    else if (camera)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "Something tells you that you won't fit");
                        turns--;
                        Write.KeyPress();
                    }
                    else if (vent)
                    {
                        if (progress == 0 || progress == 1)
                        {
                            Console.Clear();
                            Write.Line(10, 25, "Gotta open the thing up first.");
                            turns--;
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
                        turns--;
                        Write.KeyPress();
                    }
                }
            }
            //Run out of turns
            else if (turns < 1)
            {
                Console.Clear();
                Write.Line("You took too long. The guards come and take you away to be killed.");
                Write.KeyPress();
                Write.Line("Congratulations! You got the ending - Replaceable test subject.");
                Write.KeyPress();
                GameJam2020Change.Program.Start();
            }
        }
        Console.Clear();
        Write.Line("While crawling through the vent you fall through a loose panel. You managed to make it into the control room. In Front of you is a large control board with many screens. Each screen shows you camera footage. You are shocked at what you see. Many, many people in many different simulations. Some are struggling, some aren't. As you watch you notice that some of the cameras go out suddenly. Only to turn right back on, but ith someone else at the center of it now. There is only one explanation, and it's not a fond one to think about.");
        Write.KeyPress();

        int codeint = Return.RandomInt(0,999999);
        string code = codeint.ToString();

        Write.Line("As you look around you notice a control panel that requires an access code. With a sticky note next to it that reads:" + code + " Playing around with this could be dangerous.");
        Write.KeyPress();
        while (check < 2)
        {
            bool codeCheck = zorkCommand.Contains(code);
            bool escape = zorkCommand.Contains("escape");
            if (codeCheck)
            {
                Write.Line("You unlocked the panel, and subsequently started a countdown timer. A robotic voice sais “THE CLEANSING WILL BEGIN SHORTLY” . . . Well that can’t be good.The guards outside hear the commotion and enter the room and apprehend you.It is too late to stop the machine so they just keep you tied up until the countdown hits zero.Then everything goes white.Who are you again ? What were you in the past ? Who really cares anymore.All you can focus on is the blinding light.And then Silence.");
                Write.KeyPress();
                Console.Clear();
                Write.Line("Congratulations you got the ending - Purified!");
                check++;
                //Add code to unlock class or whatever is intended
            }
            else if (escape)
            {
                Write.Line("As you try to escape back the way you came. You trip and fall back onto the ground. The noise alerts the guards outside which enter the room only to swiftly apprehend you and take you away.");
                Write.KeyPress();
                Console.Clear();
                Write.Line("Congratulations you got the ending - So close!");
                check++;
                //Add code to unlock class or whatever is intended
            }
            else
            {
                Write.Line("You have 2 choices. Escape or input the code.");
                Write.KeyPress();
            }
        }
        GameJam2020Change.Program.Start();
    }
}

