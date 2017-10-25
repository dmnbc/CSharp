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
            DiscounterActor_ConsoleApplication.Actor testperson = new DiscounterActor_ConsoleApplication.Actor();
            //testperson.Liste_zeigen();
            testperson.wareEntnehmen(v);
            v.anzeigen(v.regale);
            ReadLine();
            testperson.bezahlen();
            DiscounterActor_ConsoleApplication.Kunde k = new DiscounterActor_ConsoleApplication.Kunde();
//k.Liste_zeigen();
            k.wareEntnehmen(v);
            v.anzeigen(v.regale);
            ReadLine();
            testperson.bezahlen();
            DiscounterActor_ConsoleApplication.Personal p = new DiscounterActor_ConsoleApplication.Personal();
//p.Liste_zeigen();
            p.wareEntnehmen(v);
            v.anzeigen(v.regale);
            ReadLine();

            for(int i = 0; i < 50; i++)
            {
                DiscounterActor_ConsoleApplication.Personal ptemp = new DiscounterActor_ConsoleApplication.Personal();
                //p.Liste_zeigen();
                ptemp.wareEntnehmen(v);
                v.anzeigen(v.regale);
               // ReadLine();
            }


            // einkaufen testen 
            v.anzeigen(v.regale);
            



            /*  Console.WriteLine();
              Lager l = new Lager("gemeinsamer Keller in Ossendorf",240.0);
              // l.anzeigen(); */



            ReadLine();
        }
    }
}
