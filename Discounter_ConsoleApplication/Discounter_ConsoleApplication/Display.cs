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
              Console.WriteLine("Hier kommt Regal {0} bis {1} auf den Schirm",x,y);
            for (int i = x; i <= y; i++)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                if (i % 40 == 0)
                { Console.WriteLine(); }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("."); }
            }
            Console.WriteLine();
        }

    }
}
