using System;
using static System.String;
using static System.Console;

namespace EinAusgabe_ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            int eingelesen = Read();
            WriteLine($"von der Tastatur wurde durch ReadKey {eingelesen} eingelesen.");
            ReadLine();
            WriteLine(new string('-', 20));
            string aucheingelesen = ReadLine();
            WriteLine($"von der Tastatur wurde durch ReadLine {aucheingelesen} eingelesen.");
            ReadLine();
        }
    }
}
