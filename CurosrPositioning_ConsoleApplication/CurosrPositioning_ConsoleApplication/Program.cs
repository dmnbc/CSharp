using System;
using static System.Console;

namespace CurosrPositioning_ConsoleApplication
{
    class Program
    {
        static int origRow, origCol;
        static void Main(string[] args)
        {
            
            Clear();
            origRow = CursorTop;
            origCol = CursorLeft;
            WriteLine(" Console.CursorLeft und Console.CursorTop befinden sich nach einem 'Clear' bei {0},{1}", origRow, origCol);
            Console.SetCursorPosition(WindowWidth/2,WindowHeight/2);
            WriteLine("Mit dem 'SetCursorPosition(left,top)' Befehl kann frei entschieden werden, ab wo die nächste Ausgabe erfolgt");
            
            ReadLine();
        }
    }
}
