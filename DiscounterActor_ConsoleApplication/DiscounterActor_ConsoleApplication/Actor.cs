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

        ~Actor()
        {
            
        }

        public void Liste_zeigen()
        {
            _einkaufsliste.anzeigen();
        }

        public virtual void bezahlen()
        {
            Console.WriteLine("Der Actor zahlt für");
            this.Liste_zeigen();
        }

        public void wareEntnehmen()
        {   
            // temporärer Einkaufswagen ??
            // typvorlage kann der Einkaufszettel sein

            // vermindern des Bestands im Regal 
            //  welches Regal ??  erst wenn integriert in 

            // um den Einkaufswunsch

            // also vom Einkaufszettel ablesen

            // solange nach was da ist

            // sonst nur die verfügbare Menge nehmen

            // damit bildet sich der 'Einkaufswagen' 
        }
    }
}
