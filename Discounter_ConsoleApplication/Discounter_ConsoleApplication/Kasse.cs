using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Kasse  // soll den Umsatz berechnen für jeden Kunden
                 // für den ganzen Tag 
                 // Bestandsabfragen ( pro Regal) ermöglichen
                 // Schwund ermitteln 
    {
        // Attribute
        private double kunde_umsatz;
        private double tages_umsatz;

        // Methoden

        public Kasse()
        {

        }

        public double kunde_abrechnen(/* einkaufswagen und warenkatalog */)
        {
            tages_umsatz += 11.22;  /* summe der artikelmenge * preis */;
            return 123.44; /* summe der artikelmenge * preis */;
        }

        public Einkaufszettel nachfuellen_anfordern()
        {
            return  ; 
        }

        public Einkaufszettel  fehlbestand_anzeigen()
        {
            return;
        }
    }
}
