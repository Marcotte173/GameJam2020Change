using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
public class zorkEvilEnd : Room
{
    public zorkEvilEnd()
    {
        Write.Line(10, 10, "The world around you starts to glitch. Suddenly the memories start coming back to you. This isn't a Manor, nor is this world even real. The realization finally hits you of what’s going on. You need to get out of here…");
        Write.KeyPress();

        Write.Line(10, 13, "You are standing in a metal room. ");
        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(10, 15, "Suddenly you hear a voice reverberate through the room.");
        Write.Line(10, 16, "“Ah I see you’ve finally awoken. Nicely done back there by the way, nicely done indeed. No test subject has been able to make it out of that simulation before… at least, not sane that is. Anyways I’ll send the guards to come and escort you, you are no longer of use to us. I would say it was a pleasure working with you but you won’t be alive for very long so my breath is wasted on you. Goodbye” ");
        Write.KeyPress();

        Write.Line(10, 17, "Figure out a way to escape before the guards arrive.");

        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");
        Write.Line(10, 14, "The room is empty except for a camera that appears to be watching you.");

        Write.KeyPress();
        Console.Clear();
    }
}
