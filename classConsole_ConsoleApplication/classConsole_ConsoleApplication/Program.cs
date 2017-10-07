using System;

namespace classConsole_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("The current window width is {0} Chars",Console.WindowWidth);
            Console.ReadLine();
            Console.SetWindowSize(80, 40);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The current window width is {0} Chars", Console.WindowWidth);
            Console.ReadLine();
           
        }
    }
}
