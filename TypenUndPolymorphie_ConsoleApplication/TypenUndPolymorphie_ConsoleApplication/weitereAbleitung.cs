using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypenUndPolymorphie_ConsoleApplication
{
    class WeitereAbleitung: Wurzel
    {
        public WeitereAbleitung(int i) // überladener Konstruktor
        {
            Ganzzahl = i; // nutzt den geerbten setter
        }

        public override void normalVerhalten()
        {
            Console.WriteLine("Ich bin noch toller ");
        }
    }
}
