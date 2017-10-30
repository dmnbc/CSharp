using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    internal static class Display
    {
        public static void darstellen(ref Regal[] regale,int x, int y)
        {
            if (!Program.TESTMODE) { Console.Clear(); }
            else
            {
                Console.WriteLine("Hier kommt Regal {0} bis {1} auf den Schirm", x, y);
                Console.WriteLine(" 0123456789012345678901234567890123456789");
            }
            for (int i = x; i <= y; i++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                if (i % 40 == 0)  // nach jeder Reihe von Regalen
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write(" \n ");
                    if (i % 80==0) // nach jeder Doppelreihe von Regalen
                    {
                        Console.WriteLine("{0,40}", " "); // einen Gang
                        Console.Write(" ");
                    }
                    if (regale[i].nachfuellen)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("!");
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                         Console.Write("#"); }
                    }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    if (regale[i].nachfuellen)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("!");
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else
                    {   Console.Write("#"); }
                }
            }           
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ");
            Console.WriteLine("{0,41}", " ");          
        }
    }
}
