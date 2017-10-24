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
            Random rnd = new Random(Actor.lfrNr);
            int bis = rnd.Next(1, 11);
            for (int von = 1; von <= bis; von++)
            { liste.Add(new zeile() { artikel = rnd.Next(1, 800), anzahl = rnd.Next(1, 11) }); }

        }

        public Einkaufszettel(string s)
        {

        }

        public void anzeigen()
        {
            foreach(zeile einzelzeile in liste )
            { Console.WriteLine("Artikel {0}:{1} mal", einzelzeile.artikel, einzelzeile.anzahl); }
        }
    }
}
