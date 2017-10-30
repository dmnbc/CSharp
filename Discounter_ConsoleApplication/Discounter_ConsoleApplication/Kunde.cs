using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    class Kunde : Actor
    {
        public Kunde()
        {
            ConsoleColor temp = Console.ForegroundColor;
            if (Program.TESTMODE) {  Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Kunde() startet");
            } 
                this.id = Actor.lfrNr;
            if (Program.TESTMODE)
               { Console.WriteLine("Kunde() endet:  Actor-Objekt {0}", id);
               Console.ForegroundColor = temp;
                Console.ReadLine();
            }       
        }

        public override void bezahlen(ref Kasse ks)
        {
            ConsoleColor temp = Console.ForegroundColor;
            if (Program.TESTMODE)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Kunde.bezahlen() startet");
            }
            double umsatz;
            umsatz = ks.kunde_abrechnen(einkaufswagen);
            if (Program.TESTMODE)
            {
                Console.WriteLine("Der Kunde zahlt den offiziellen Preis ");
                Console.WriteLine("von {0,6:F2} Euro", umsatz);
                Console.WriteLine("Kunde.bezahlen() endet");
                Console.ForegroundColor = temp;
                Console.ReadLine();
            }
        }
    }
}
