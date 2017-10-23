using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Actor
    {
        static public int lfrNr;
        protected Einkaufszettel _einkaufsliste;
        protected int id;
        private int rolle;

        public Einkaufszettel einkaufsliste
        {
            get
            {
                return _einkaufsliste;
            }

            set
            { 

            }
        }

        public Actor()
        {
            lfrNr++;
            _einkaufsliste = new Einkaufszettel();
            Console.WriteLine("Es wurde zuerst ein Actor aufgerufen");

        }

        public void Liste_zeigen()
        {
            _einkaufsliste.anzeigen();
        }
    }
}
