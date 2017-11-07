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

            // auf ein existierendes Rechteck ein weiteres hinzuaddieren
            blumenbeet += rasen;
            Console.WriteLine("Der Zaun ums neue Blumenbeet ist {0} Meter lang", blumenbeet.umfang);
           
            Console.WriteLine("Es müssen hier jetzt {0,4:F2} Qudratmeter begossen werden ", blumenbeet.flaeche);
            Console.ReadLine();

            Kreis _1meterTeich = new Kreis(1);
            Kreis neuTeich = _1meterTeich + _1meterTeich;
            Console.WriteLine(" Neuteich  Umfang: {0,3:F2}, Fläche: {1,3:F2}", neuTeich.umfang, neuTeich.flaeche);



            Console.ReadLine();
        }
    }
}
