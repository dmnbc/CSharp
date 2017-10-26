using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CursorBewegen_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int runs = 0; runs < 100; runs++)
            {
                int spalte = 0;
                for (int zeile = 0; zeile < 40; zeile++)
                {

                    if (zeile < 20)
                    { SetCursorPosition(spalte++, zeile); }
                    else
                    { SetCursorPosition(spalte--, zeile); }

                    Write('x');
                }
            }
            ReadLine();

        }
    }
}
