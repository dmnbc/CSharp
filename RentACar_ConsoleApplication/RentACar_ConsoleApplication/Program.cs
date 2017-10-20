using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Fahrzeug meinDienstwagen = new Fahrzeug(true, true, "Red", "SU K 111");
            Fahrzeug f2 = new Fahrzeug(true, false, "Blue", "MZG K 121");
            Fahrzeug f3 = new Fahrzeug(false, true, "Green", "BM K 331");
            Fahrzeug f4 = new Fahrzeug(false,false, "Black", "K K 21");
            Fahrzeug f5 = new Fahrzeug(true, true, "Yellow", "BN K 211");

            Console.ReadLine();
            Parkplatz hinterDemBüro = new Parkplatz();
            hinterDemBüro.abstellen(meinDienstwagen);

            Console.WriteLine("Auf dem Platz Nr. 9 steht {0} Fahrzeug", hinterDemBüro.parkplatz[9].farbe);
            Console.WriteLine("Kennzeichen : {0}", hinterDemBüro.parkplatz[9].kennzeichen);

            Console.ReadLine();


        }
    }
}
