using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    public class Einkaufszettel
    {
        public struct zeile
        {
            public int artikel;
            public int anzahl;
        }

        // generic Container nutzen 
        public List<zeile> liste = new List<zeile>();


        public Einkaufszettel()
        {
            for (int von = 1; von <= 3; von++)
            { liste.Add(new zeile() { artikel = von, anzahl = von }); }

        }

        public void anzeigen()
        {
            foreach(zeile einzelzeile in liste )
            { Console.WriteLine("Artikel {0}:{1} mal", einzelzeile.artikel, einzelzeile.anzahl); }
        }
    }
}
