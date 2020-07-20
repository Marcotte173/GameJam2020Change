using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class Write
{
    public static void Line(string text)
    {
        Console.Write(text + "\n" + Color.RESET);
    }
    public static void Line(string colour, string text)
    {
        Console.Write($"{colour}" + $"{text}" + Color.RESET);
    }
    public static void Line(int x, int y, string text)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(text + Color.RESET);
    }

    public static void Line(string colour, int x, int y, string text)
    {
        Console.SetCursorPosition(x, y);
        Console.Write($"{colour}" + $"{text}" + Color.RESET);
    }

    public static void Line(string colour, string text1, string text2, string text3)
    {
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}\n" + Color.RESET);
    }
    public static void Line(string colour, int x, int y, string text1, string text2, string text3)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour + $"{text2}"
            + Color.RESET + $"{text3}\n" + Color.RESET);
    }

    public static void Line(string colour, string colour2, string text1, string text2, string text3, string text4, string text5)
    {
        Console.Write(
            $"{text1}"
            + colour
            + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}\n" + Color.RESET);
    }

    public static void Line(string colour, string colour2, int x, int y, string text1, string text2, string text3, string text4, string text5)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(
            $"{text1}"
            + colour
            + $"{text2}"
            + Color.RESET + $"{text3}"
            + colour2 + $"{text4}"
            + Color.RESET + $"{text5}\n" + Color.RESET);
    }

    public static void KeyPress(int x, int y)
    {
        Write.Line(x, y, "Press any key to continue");
        Console.ReadKey();
    }
    public static void KeyPress()
    {
        Write.Line(0, 26, "Press any key to continue");
        Console.ReadKey();
    }

    internal static void DotDotDotSL()
    {
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(400);
            Console.Write(".");
        }
    }
}