using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypenUndPolymorphie_ConsoleApplication
{
    class Ableitung: Wurzel
    {
        // durch die Vererbung hat Ableitung
        // die public Attribute ganzzahl, 
        // die Methoden Ganzahl und Ganzzahlbeschaffer

        // und ruft bei seiner Instanzierung
        // den parameterlosen Konstruktor von Wurzel auf 

        public Ableitung(int i) // überladener Konstruktor
        {
            Ganzzahl = i; // nutzt den geerbten setter
        }
    }
}
