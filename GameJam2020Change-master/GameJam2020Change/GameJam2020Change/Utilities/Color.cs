using System;
using System.Runtime.InteropServices;

public class Color
{
    //ESCAPE CODES FOR COLOUR
    public const string BOLD = "\u001B[1m";
    public const string RED = "\u001b[38;5;9m";
    public const string BLUE = "\u001b[38;5;33m";
    public const string GREEN = "\u001b[38;5;10m";
    public const string YELLOW = "\u001b[38;5;11m";
    public const string GREY = "\u001b[38;5;241m";
    public const string GOLD = "\u001b[38;5;136m";
    public const string RESET = "\u001B[1m\u001B[37m";


    const int STD_OUTPUT_HANDLE = -11;
    const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);
    [DllImport("kernel32.dll")]
    static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);
    [DllImport("kernel32.dll")]
    static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

    public static void SetupConsole()
    {
        IntPtr handle = GetStdHandle(STD_OUTPUT_HANDLE);
        uint mode;
        GetConsoleMode(handle, out mode);
        mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
        SetConsoleMode(handle, mode);
    }
}