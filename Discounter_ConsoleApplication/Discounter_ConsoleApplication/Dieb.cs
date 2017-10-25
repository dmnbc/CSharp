using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Dieb:Kunde
    {
        
        public Dieb()
        {
            this.id = Actor.lfrNr;
            Console.WriteLine("Ich bin ein Dieb und das Objekt {0}",id);
        }

        public override void bezahlen()
        {
            Console.WriteLine("Der Dieb zahlt nichts");
        }

        ~Dieb()
        {
          
        }
    }
}
