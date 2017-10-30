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
            Console.WriteLine("Kasse ist geöffnet");
        }

        public double kunde_abrechnen( WasWieOft_Liste ekw )
        {   // für jeden Artikel im Einkaufswagen, muss der passende Preis
            // aus dem Warenkatalog beschafft werden
            kunde_umsatz = 0.0;
            for (int i = 0; i < ekw.liste.Count;i++)     // durch den Einkaufswagen mit Schleife
            {
                if (Program.TESTMODE) { Console.WriteLine("Artikel {0,3}, {1,3} mal a {2,4:F2} Euro",
                                                    ekw.liste[i].artikel, ekw.liste[i].anzahl, Warenkatalog.warenkatalog[ekw.liste[i].artikel].art_einzelpreis); }
                kunde_umsatz += ekw.liste[i].anzahl * Warenkatalog.warenkatalog[ekw.liste[i].artikel].art_einzelpreis;
            } 
            tages_umsatz += kunde_umsatz;  
            return kunde_umsatz;  // Kasse meldet dem Actor den Warensummenwert
        }

        public WasWieOft_Liste  fehlbestand_feststellen(Discounter_ConsoleApplication.Raum v)
        {
            // Über alle Regale wandern und jedes mit "nachfüllen = True"
            // in die Fehlliste eintragen 

            WasWieOft_Liste arbeitsliste = new WasWieOft_Liste("Fehlliste");
           for(int i = 0; i < v.regale.Length; i++)
            {
               if( v.regale[i].nachfuellen == true)
                { if (Program.TESTMODE)
                    {
                        Console.WriteLine(" Regal {0} muss aufgefüllt werden ", i);
                        Console.WriteLine(" Es fehlen zum Maximalbestand {0} Einheiten", v.regale[i].kapazität - v.regale[i].aktuellerInhalt);
                    }
                    arbeitsliste.liste.Add(new WasWieOft_Liste.zeile()
                    { artikel = i, anzahl = v.regale[i].kapazität - v.regale[i].aktuellerInhalt });
                }
            }
             return arbeitsliste;
        }
    }
}
