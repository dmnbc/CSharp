using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_ConsoleApplication
{
    class Parkplatz
    {
        public Fahrzeug[] parkplatz = new Fahrzeug[10];
        public void abstellen(Fahrzeug f)
        {
            int i = parkplatz.Length-1;
            Console.WriteLine("Fahrzeug wird gestellt auf Platz {0}", i);
            parkplatz[i] = f;
        }

    }
}
