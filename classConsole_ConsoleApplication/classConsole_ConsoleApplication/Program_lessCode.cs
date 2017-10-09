using System;
using static System.Console;   // erspart das führende Console.  vor Methoden und Eigenshaften
using static System.ConsoleColor;
namespace classConsole_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BackgroundColor = (System.ConsoleColor)10;
            Clear();
            WriteLine("The current window width is {0} Chars",Console.WindowWidth);
            ReadLine();
           
            SetWindowSize(LargestWindowWidth/2, LargestWindowHeight/2);
            BackgroundColor = DarkGreen;
            Clear();
            WriteLine("The current window width is {0} Chars", Console.WindowWidth);
            ReadLine();
            
        }
    }
}
