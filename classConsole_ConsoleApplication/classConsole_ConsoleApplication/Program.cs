﻿using System;
using static System.Console;

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
