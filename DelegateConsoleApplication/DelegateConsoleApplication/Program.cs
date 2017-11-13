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

            faerbe =  new ConsoleHandler(ScreenManipulation.schriftfarbe);
            faerbe += new ConsoleHandler(ScreenManipulation.hintergrundfarbe);

            faerbe(ConsoleColor.Green);
            Console.WriteLine("abcde");
            faerbe(ConsoleColor.Black);
            Console.WriteLine("abcde");

            for(int i = 0; i <16; i++)
            { faerbe((ConsoleColor)i);
                Console.WriteLine("abcde");
            }

            Console.ReadLine();
            int i;
            /*  vom Arbeitsvorbereiter definierte Liste der Jobs */
            List<ConsoleHandler> myJobs = new List<ConsoleHandler>();
            myJobs.Add(ScreenManipulation.schriftfarbe);
            myJobs.Add(ScreenManipulation.hintergrundfarbe);
            myJobs.Add(ScreenManipulation.drawLine);
           

            /* Abarbeiten einer Liste mit unbekantem Inhalt */
            ConsoleHandler delJobs = new ConsoleHandler(ScreenManipulation.start);
            foreach(ConsoleHandler task in myJobs)
            { delJobs += task; }   // alle Jobs der Liste annehmen

            delJobs(ConsoleColor.White);
            Console.WriteLine("xyz");


            Console.ReadLine();
        }
    }

    class ScreenManipulation
    {
        public static void schriftfarbe(ConsoleColor f)
        {
            Console.ForegroundColor = f;
        }

        public static void hintergrundfarbe(ConsoleColor f)
        {
            ConsoleColor komp = (ConsoleColor)(15 - f);
            Console.BackgroundColor =komp;
        }
        public static void start(ConsoleColor f)
        {
            ;
        }
        public static void drawLine(ConsoleColor f)
        {
           Console.WriteLine("_______________________________");
        }
    }
}
