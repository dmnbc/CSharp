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
            Console.Clear();
            Console.WriteLine("Hier kommt Regal {0} bis {1} auf den Schirm",x,y);
            for (int i = x; i <= y; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (i % 40 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                    Console.WriteLine();
                    Console.Write(" ");
                    if (i % 80==0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("{0,40}", " ");
                        Console.Write(" ");
                    }
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
                    { Console.Write("#"); }
                }
            }
            
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" ");
            Console.WriteLine("{0,41}", " ");
           
        }

    }
}
