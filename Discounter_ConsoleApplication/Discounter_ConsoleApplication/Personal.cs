using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscounterActor_ConsoleApplication
{
     class Personal : Actor
    {
        
        public Personal()
        {
            this.id = Actor.lfrNr;
            Console.WriteLine("Ich bin beim Personal und das Objekt {0}", id);
        }
        public override void bezahlen()
        {
            Console.WriteLine("Das Personal zahlt mit Rabatt");
        }

        ~Personal()
        {
           
        }
    }
}