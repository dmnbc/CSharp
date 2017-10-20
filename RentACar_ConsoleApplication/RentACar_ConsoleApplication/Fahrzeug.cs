using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_ConsoleApplication
{
    class Fahrzeug
    {
        public bool fuchsschwanz;
        public bool ledersitze;
        public string farbe;
        public string kennzeichen;

        public Fahrzeug(bool f, bool l, string fa, string k)
        {
            fuchsschwanz = f;
            ledersitze = l;
            farbe = fa;
            kennzeichen = k;
            Console.WriteLine("Fahrzeug {0} wurde als Objekt erstellt", k);

        }
    }
}
