using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{  
    public class WasWieOft_Liste
    {
         public struct zeile
        {
            public int artikel;
            public int anzahl;
            private int i;
            private int aktuellerInhalt;

            public zeile(int i, int aktuellerInhalt) : this()
            {
                this.i = i;
                this.aktuellerInhalt = aktuellerInhalt;
                artikel = i; ;
                anzahl = aktuellerInhalt;
        }
        }

        // generic Container List nutzen 
        public List<zeile> liste = new List<zeile>();

        public WasWieOft_Liste()   // generiert Einkaufszettel
        {
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WasWieOft_Liste() startet, ");
                Console.ForegroundColor = tmp;
            }
            Random rnd = new Random(Actor.lfrNr);  // noch keine echten Zufälle, jedes Objekt mit gleicher id ist gleich
            int bis = rnd.Next(1, 11);
            for (int von = 1; von <= bis; von++)
            { liste.Add(new zeile() { artikel = rnd.Next(1, 800), anzahl = rnd.Next(1, 20) }); }
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                liste.Add(new zeile() { artikel = Actor.lfrNr, anzahl = 1000 });
                liste.Add(new zeile() { artikel = 799, anzahl = 25 });

                anzeigen();
                Console.WriteLine("WasWieOft_Liste() endet");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
        }

        // Überladungen für Einkaufswagen, Transportwagen, Auftragsliste 
        public WasWieOft_Liste(string s, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                                         [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                                         [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WasWieOft_Liste(string {0}) aufgerufen,",s);
                Console.WriteLine("{0} wurde bereitgestellt. Aufruf durch {1} ", s,memberName);
                Console.WriteLine("in {0}: {1}", sourceFilePath, sourceLineNumber);
                Console.ForegroundColor = tmp; }
            ; // wird genutzt, um einen leeren Einkaufswagen zu erzeugen
        }

        public void anzeigen()
        {   // zeigt die Zeilen des  WasWieOft_Liste - Objektes an
            // dabei kann es sich um Einkaufszettel, Einkaufswagen, Fehlliste und Lageraufträge handeln.
            foreach (zeile einzelzeile in liste )
            { Console.WriteLine("Artikel {0}:{1} mal", einzelzeile.artikel, einzelzeile.anzahl); }
        }
    }
}
