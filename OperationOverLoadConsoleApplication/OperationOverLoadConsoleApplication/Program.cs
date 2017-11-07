using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOverLoadConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechteck blumenbeet = new Rechteck(10, 15) { bepflanzung = "Gras" };
           
            Console.WriteLine("Der Zaun ums Blumenbeet ist {0} Meter lang", blumenbeet.umfang);
            Console.WriteLine(blumenbeet.bepflanzung);
            Console.WriteLine("Es müssen hier {0,4:F2} Qudratmeter begossen werden ", blumenbeet.flaeche);
            Console.ReadLine();

            Rechteck rasen = new Rechteck(40,80) { bepflanzung = "Gras" };

            Console.WriteLine("Die Linie um den Rasen ist {0} Meter lang", rasen.umfang);
            
            Console.WriteLine("Es müssen hier {0,4:F2} Qudratmeter begossen werden ", rasen.flaeche);
            Console.ReadLine();

            double gesamtFlache = rasen.flaeche + blumenbeet.flaeche;
            double gesamtUmfang = rasen.umfang + blumenbeet.umfang;

                                   // Operatoren überladen, zusätzlich definieren was macht ein
                                   //  + zwischen zwei Objekten von Klasse Rechteck 
            Rechteck neuesRechteck = rasen + blumenbeet;
            Console.WriteLine("Die Linie um das neue Rechteck ist {0} Meter lang", neuesRechteck.umfang);
            Console.WriteLine("Die gemeinsame Fläche für das neue Rechteck ist {0} Quadratmeter groß", neuesRechteck.flaeche);

            Console.WriteLine("{0} mal {1}", neuesRechteck.breite, neuesRechteck.laenge);





            Console.ReadLine();
        }
    }
}
