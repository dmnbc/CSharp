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
            DiscounterActor_ConsoleApplication.Kasse kasse = new DiscounterActor_ConsoleApplication.Kasse(ref wk);

            Verkauf v = new Verkauf("Im2.OG_Hohe Strasse",400.0, ref Warenkatalog.warenkatalog);
            v.anzeigen(v.regale);       // der ganze Raum 
                            
            ReadLine();


                DiscounterActor_ConsoleApplication.Kunde k = new DiscounterActor_ConsoleApplication.Kunde();
                k.einkaufswagen = k.wareEntnehmen(v);
                v.anzeigen(v.regale);
                k.bezahlen(ref kasse); // wird polymorph weitergegeben an  kasse.kunde_abrechnen();
               
               // kunde aus dem Speicher entfernen 
               //  k = null; GC.Collect();
            ReadLine();
            
            v.anzeigen(v.regale);

            DiscounterActor_ConsoleApplication.Personal p1 = new DiscounterActor_ConsoleApplication.Personal();
            p1.einkaufswagen = p1.wareEntnehmen(v);
            v.anzeigen(v.regale);
            p1.bezahlen(ref kasse); // wird polymorph weitergegeben an  kasse.kunde_abrechnen();
            ReadLine();
            DiscounterActor_ConsoleApplication.Personal p2 = new DiscounterActor_ConsoleApplication.Personal();
            p2.einkaufswagen = p2.wareEntnehmen(v);
            v.anzeigen(v.regale);
            p2.bezahlen(ref kasse); // wird polymorph weitergegeben an  kasse.kunde_abrechnen();
            ReadLine();

            v.anzeigen(v.regale);



            /*  Console.WriteLine();
              Lager l = new Lager("gemeinsamer Keller in Ossendorf",240.0);
              // l.anzeigen(); */



            ReadLine();
        }
    }
}
