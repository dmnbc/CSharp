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
        public static bool TESTMODE = true;
        public static bool STEPWISE = true;
        static void Main(string[] args)
        {

            Warenkatalog wk = new Warenkatalog();
            Discounter_ConsoleApplication.Kasse kasse = new Discounter_ConsoleApplication.Kasse(ref wk);

            Verkauf v = new Verkauf("Im2.OG_Hohe Strasse",400.0, ref Warenkatalog.warenkatalog);
            v.anzeigen(v.regale);       // der ganze Raum 

            Console.WriteLine("Wert aller Regale bei der Eröffnung: {0} ", kasse.momentanWert(v));

            //gesucht werden alle Regal-IDs, wo die Regale mehr Wert sind als 500 Euro
            var mehrAls500Wert = from inhalt in v.regale where  inhalt.aktuellerWarenwert >500 select inhalt.regal_id;
            foreach(var item in mehrAls500Wert)
            {
                Console.WriteLine("Das Regal {0} ist mehr als 500 Euro wert ",item);
            }


            if (Program.TESTMODE)
            { Console.ReadLine(); }

                Lager l = new Lager("gemeinsamer Keller in Ossendorf", 240.0, ref Warenkatalog.warenkatalog);
            // l.anzeigen(l.regale);


            ReadLine();


                Discounter_ConsoleApplication.Kunde k = new Discounter_ConsoleApplication.Kunde();
                k.einkaufswagen = k.wareEntnehmen(v);
                v.anzeigen(v.regale);
                k.bezahlen(ref kasse); // wird polymorph weitergegeben an  kasse.kunde_abrechnen();
               
               // kunde aus dem Speicher entfernen 
               //  k = null; GC.Collect();
            ReadLine();
            
            v.anzeigen(v.regale);

            /*
            Console.WriteLine("Wert aller Regale nach den Einkäufen: {0} ", kasse.momentanWert(v));
            if (Program.TESTMODE)
            { Console.ReadLine(); }
            */

            /*
            Discounter_ConsoleApplication.Personal p1 = new Discounter_ConsoleApplication.Personal();
            p1.einkaufswagen = p1.wareEntnehmen(v);
            v.anzeigen(v.regale);
            p1.bezahlen(ref kasse); // wird polymorph weitergegeben an  kasse.kunde_abrechnen();
            ReadLine();
            Discounter_ConsoleApplication.Personal p2 = new Discounter_ConsoleApplication.Personal();
            p2.einkaufswagen = p2.wareEntnehmen(v);
            v.anzeigen(v.regale);
            p2.bezahlen(ref kasse); // wird polymorph weitergegeben an  kasse.kunde_abrechnen();
            ReadLine();

            v.anzeigen(v.regale);
            */
            // 
            Console.WriteLine("Der Auftrag an den Lageristen umfasst :");
            kasse.fehlbestand_feststellen(v).anzeigen();

            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Instanzierung des Lageristen ");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
            Lagerist laggy = new Lagerist();
            laggy.umlagern(kasse.fehlbestand_feststellen(v),ref l,ref v);
            // filialleiter.bestellen(kasse.fehlbestand_feststellen(l),ref lief,ref l);
            if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }



            v.anzeigen(v.regale);
             
               



            ReadLine();
        }
    }
}
