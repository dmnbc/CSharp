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
        static void Main(string[] args)
        {

            Warenkatalog wk = new Warenkatalog();
            Discounter_ConsoleApplication.Kasse kasse = new Discounter_ConsoleApplication.Kasse(ref wk);

            Verkauf v = new Verkauf("Im2.OG_Hohe Strasse",400.0, ref Warenkatalog.warenkatalog);
            v.anzeigen(v.regale);       // der ganze Raum 
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

            // 
            Console.WriteLine("Der Auftrag an den Lageristen umfasst :");
            kasse.fehlbestand_feststellen(v).anzeigen();

           
            Discounter_ConsoleApplication.Lagerist laggy = new Discounter_ConsoleApplication.Lagerist();
            laggy.umlagern(kasse.fehlbestand_feststellen(v),ref l,ref v);
            // filialleiter.bestellen(kasse.fehlbestand_feststellen(l),ref lief,ref l);
            Console.WriteLine("Lagerist ist fertig ");
           

            v.anzeigen(v.regale);
             
               



            ReadLine();
        }
    }
}
