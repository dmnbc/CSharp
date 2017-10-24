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

        public override void bezahlen()
        {
            Console.WriteLine("Der Kunde zahlt den offiziellen Preis ");
        }


         ~Kunde()
        {
            
        }

    }
}
