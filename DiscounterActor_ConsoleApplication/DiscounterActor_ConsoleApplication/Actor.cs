using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Actor
    {
        protected Einkaufszettel _einkaufsliste;
        private int id;
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
            _einkaufsliste = new Einkaufszettel();

        }

        public void Liste_zeigen()
        {
            _einkaufsliste.anzeigen();
        }
    }
}
