using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Kunde : Actor
    {
        // private int k_id;
        public Kunde()
        {
            this.id = Actor.lfrNr;
            Console.WriteLine("Ich bin ein Kunde und das Objekt {0}",id);
        }

        public override void bezahlen(ref Kasse ks)
        {
            Console.WriteLine("Der Kunde zahlt den offiziellen Preis ");
           // Console.WriteLine("für {0} Artikel ", einkaufswagen.liste.Count);
            Console.WriteLine("von {0,6:F2} Euro", ks.kunde_abrechnen(einkaufswagen));
        }


         ~Kunde()
        {
            
        }

    }
}
