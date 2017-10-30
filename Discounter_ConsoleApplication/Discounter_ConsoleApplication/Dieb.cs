using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    // versiegelt, von Dieb kann nicht weiter abgeleitet werden
    sealed class Dieb:Kunde  
    {        
        public Dieb()
        {
            this.id = Actor.lfrNr; // statische Klasenvariable wird in Actor fortlaufend erhöht
            if (Program.TESTMODE) { Console.WriteLine("Ich bin ein Dieb und habie die id: {0}", id); }
        }

        public override void bezahlen(ref Kasse ks)
        {
            if (Program.TESTMODE) { Console.WriteLine("Der Dieb zahlt nichts"); }
        }
    }
}
