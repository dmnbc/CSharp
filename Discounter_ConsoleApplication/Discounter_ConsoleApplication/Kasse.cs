using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Discounter_ConsoleApplication
{
    class Kasse  // soll den Umsatz berechnen für jeden Kunden
                 // für den ganzen Tag 
                 // Bestandsabfragen ( pro Regal) ermöglichen
                 // Schwund ermitteln und Nachfüllanforderungen erstellen
    {
        // Attribute
        private double kunde_umsatz;
        private double tages_umsatz;
        public bool offen;

        // Methoden
        public Kasse(ref Warenkatalog wk)
        {
            offen = true;
            kunde_umsatz = 0.0;
            tages_umsatz = 0.0;
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kasse ist geöffnet");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
        }

        public double kunde_abrechnen(WasWieOft_Liste ekw)
        {   // für jeden Artikel im Einkaufswagen, muss der passende Preis
            // aus dem Warenkatalog beschafft werden
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kasse.kunde_abrechnen( aus Einkaufswagen) ");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
            kunde_umsatz = 0.0;
            for (int i = 0; i < ekw.liste.Count; i++)     // durch den Einkaufswagen mit Schleife
            {
                if (Program.TESTMODE)
                {
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Artikel {0,3}, {1,3} mal a {2,4:F2} Euro",
                                                    ekw.liste[i].artikel, ekw.liste[i].anzahl, Warenkatalog.warenkatalog[ekw.liste[i].artikel].art_einzelpreis);
                    Console.ForegroundColor = tmp;
                }
                kunde_umsatz += ekw.liste[i].anzahl * Warenkatalog.warenkatalog[ekw.liste[i].artikel].art_einzelpreis;
            }
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kasse meldet dem Actor den Warensummenwert {0}", kunde_umsatz);
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
            tages_umsatz += kunde_umsatz;
            return kunde_umsatz;  // Kasse meldet dem Actor den Warensummenwert
        }

        public WasWieOft_Liste fehlbestand_feststellen(Discounter_ConsoleApplication.Raum v)
        {
            // Über alle Regale wandern und jedes mit "nachfüllen = True"
            // in die Fehlliste eintragen 
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Kasse.fehlbestand_feststellen( in einem Raum) ");
                Console.ForegroundColor = tmp;

            }
            WasWieOft_Liste arbeitsliste = new WasWieOft_Liste("Lagerist");

            var fehlliste = from inhalt in v.regale
                            where inhalt.nachfuellen
                            select new { id = inhalt.regal_id,
                                menge = inhalt.kapazität - inhalt.aktuellerInhalt };

            foreach (var item in fehlliste)
            { arbeitsliste.liste.Add(new WasWieOft_Liste.zeile(item.id, item.menge));






                if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0}\t{1}", item.id, item.menge);
                    Console.ForegroundColor = tmp;


            }
          } 
             return arbeitsliste;
        }

        public double momentanWert(Raum r)
        {
            double gesamtWert = 0;
            var warenwert = from inhalt in r.regale select inhalt.aktuellerWarenwert;
            gesamtWert = warenwert.Sum();
            return gesamtWert;
        }
    }
}
