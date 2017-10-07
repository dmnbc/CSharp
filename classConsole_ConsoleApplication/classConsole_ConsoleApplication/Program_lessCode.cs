using System;
using static System.Console;   // erspart das führende Console.  vor Methoden und Eigenshaften

namespace classConsole_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BackgroundColor = ConsoleColor.Blue;
            WriteLine("The current window width is {0} Chars",Console.WindowWidth);
            ReadLine();
            SetWindowSize(80, 40);
            BackgroundColor = ConsoleColor.DarkGreen;
            WriteLine("The current window width is {0} Chars", Console.WindowWidth);
            ReadLine();
           
        }
    }
}
