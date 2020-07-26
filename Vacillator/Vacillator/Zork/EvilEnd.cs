using GameJam2020Change;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
public class EvilEnd
{
    public static void Start()
    {
        Write.Line(10, 10, "The world around you starts to glitch. Suddenly the memories start coming back to you. This isn't a Manor, nor is this world even real. But in reality. Who really cares? A kill is a kill no matter what world it’s in. And people are so much easier to dispose of than monsters.");
        Write.KeyPress();

        Write.Line(10, 13, "You are standing in a metal room. ");
        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(10, 15, "Suddenly you hear a voice reverberate through the room.");
        Write.Line(10, 16, "“Ah I see you’ve finally awoken.”");
        Write.Line(10, 16, "But, before the voice gets another word in you cut them off.");
        Write.Line(10, 16, "“Let’s cut the formalities shall we? We both know what you plan to do with me now. And we both know you aren’t planning on letting me out of here alive.”");
        Write.Line(10, 16, "The voice responds, tho sounding a lot more aggressive than before. “Ah so you are aware of your position, well how about this, you go with the guards like a good little test subject. And we won't have to get rough with you. Deal?”");
        Write.Line(10, 16, "You just sit there and chuckle at the absurdity. Heh, going quietly. Oh no, if you are going down, you are taking as many as you can with you!");
        Write.KeyPress();

        Write.Line(10, 17, "You have 5 turns. Find a weapon =)");

        int turns = 5;
        int check = 0;
        string zorkCommand = Console.ReadLine();
        bool weapon = false;

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
                        Write.Line(10, 25, "The room is empty except for a camera. Looking around further reveals a small ventilation system. The screws are rusted, should be easy enough to pull off. Rusty screws make for such good weapons, don’t you think? =)");
                        turns--;
                        Write.KeyPress();
                    }
                    else if (camera)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "I wonder who's behind it? =)");
                        turns--;
                        Write.KeyPress();
                    }
                    else if (vent)
                    {
                        Console.Clear();
                        Write.Line(10, 25, "The cover is held in place by some rusty screws. They'd make for good weapons =)");
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
                            Write.Line(10, 25, "Hitting the camera caused it to fall to the ground and shatter, aggravating the one behind it further. Human emotions can be so easy to manipulate =)");
                            progress++;
                            turns -= 2;
                            Write.KeyPress();
                        }
                        else
                        {
                            Console.Clear();
                            Write.Line(10, 25, "The camera is already broken. It's parts are useless to me.");
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
                            Write.Line(10, 25, "Opening up that camera wouldn't exactly help much.");
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
                            Write.Line(10, 25, "You tear the vent lid off and take out the screws to use as a weapon. The camera is still watching you but the one behind it has become even more pissed off. Is that fear in their voice? =)");
                            turns--;
                            progress += 2;
                            weapon = true;
                            Write.KeyPress();
                        }
                        else if (progress == 1)
                        {
                            Console.Clear();
                            Write.Line(10, 25, "You tear the vent lid off and take out the screws to use as a weapon.");
                            turns--;
                            progress++;
                            weapon = true;
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
                        Console.Clear();
                        Write.Line(10, 25, "Now, Why would I want to run from such a perfect situation?");
                        turns--;
                        Write.KeyPress();   
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
            else if (turns < 1 && weapon == false)
            {
                Console.Clear();
                Write.Line("The guards enter the room to try grab you and take you away. But you aren’t going down without a fight! You manage to snap the neck of the first guard and knock out the other one with a strong punch to the gut, before making a break for it. As you continue to run down the halls, and being chased by an ever increasing number of guards you are finally caught in a dead end. You turn around to try and fight them off but there are too many of them to handle. You are quickly subdued and terminated on the spot.");
                Write.KeyPress();
                Write.Line("Congratulations you. . . not enough blood. You worthless runner!");
                Write.KeyPress();
                Environment.Exit(1);
            }
            else if (turns < 1 && weapon == true)
            {
                check++;
            }
        }
        Console.Clear();
        Write.Line("Ah here come the guards. I wonder just how many I’ll get to kill =)");
        Write.Line("The first 2 guards enter the room to try and capture you. That's 2 dead =)");
        Write.Line("You exit the containment area, sirens blaring all around you as guards are coming from all sides. It will take more than a few guards to get rid of me. hah. hahaha. Hahahaha. hahaHAHAHAAHAHA!");
        Write.Line("You fight your way through the hordes of guards. Brutally murdering each and every guard that dares stand in your way until you reach the command room. This is where the one in charge of the facility is hiding. Such a fool to believe I won't make it to them as well.");
        Write.Line("You burst through the door and proceed to pin them to the wall.");
        Write.Line("SAY GOODBYE YOU PATHETIC FOOL!");
        Write.Line("As you slit the throat of their leader. You feel a sharp pain in your back. You’ve been shot, but before you can do much else 3 more shots ring out, the final bullet hitting you in the head, killing you on the spot.");

        Write.KeyPress();
        Write.Line("Congratulations! You got the ending - Burning in hell!");
        Write.KeyPress();
        GameJam2020Change.Program.Start();
    }
}
