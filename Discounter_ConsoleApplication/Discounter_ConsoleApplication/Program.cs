using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    

    class Program
    {
        // Warenkatalog laden per 

        
        static void Main(string[] args)
        {

            Warenkatalog wk = new Warenkatalog();

            Verkauf v = new Verkauf("Im2.OG_Hohe Strasse",400.0, ref wk.warenkatalog);
            v.anzeigen(v.regale);       // der ganze Raum 
                            
            ReadLine();
            // einkaufen testen 
            v.anzeigen(v.regale);
            v.regale[4].aktuellerInhalt  -= 2;
            v.regale[4].nachfuellen = v.regale[4].aktuellerInhalt < 30;
            v.anzeigen(v.regale,0,180);



            /*  Console.WriteLine();
              Lager l = new Lager("gemeinsamer Keller in Ossendorf",240.0);
              // l.anzeigen(); */



            ReadLine();
        }
    }
}
