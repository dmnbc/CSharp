using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateConsoleApplication
{
    public delegate void ConsoleHandler(ConsoleColor value);
    class Program
    {
        
        static void Main(string[] args)
        {
            ConsoleHandler faerbe;

            faerbe = new ConsoleHandler(ScreenManipulation.schriftfarbe);

            faerbe(ConsoleColor.Green);
            Console.Write("abcde");

            Console.ReadLine();
           
        }
    }

    class ScreenManipulation
    {
        public static void schriftfarbe(ConsoleColor f)
        {
            Console.ForegroundColor = f;
        }
    }
}
