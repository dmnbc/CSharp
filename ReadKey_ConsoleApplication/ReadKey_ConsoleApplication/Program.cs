using System;


namespace ReadKey_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int zeile = 0;
            int spalte = 0;

            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                switch(cki.Key.ToString())
                {
                    case "LeftArrow" : spalte--  ;break;
                  /*  case :; break;
                    case :; break;
                    case :; break; */
                    default: break;
                }
                Console.WriteLine(zeile + "," + spalte);


                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
