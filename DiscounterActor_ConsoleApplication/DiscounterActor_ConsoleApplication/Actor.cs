using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Actor
    {
        public struct zeile {
            int art;
            int anz;
        }
        static public int lfrNr;
        protected Einkaufszettel _einkaufsliste;
        protected Einkaufszettel _einkaufswagen;
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

        public Einkaufszettel einkaufswagen
        {
            get
            {
                return _einkaufswagen;
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
            for(int i = 0; i < _einkaufsliste.liste.Count;i++)
            {
                // vermindern des Bestands im Regal 
                //  welches Regal ??  erst wenn integriert in 
                // um den Einkaufswunsch
                // also vom Einkaufszettel ablesen 
                Console.WriteLine(" vom zettel : {0}", _einkaufsliste.liste[i].artikel);
                //            if(  >  )
                //             { // genug im Regal

                // einkaufswagen.liste.Add = // wunsch
                // Verkauf[xx].   -= wunsch;
                //              }
                //              else
                //              { // zu wenig im Regal, alles was noch da ist
                // einkaufswagen.liste. = // Verkauf[xx].
                // Verkauf[xx].   = 0;
                //               }
                // einkaufswagen.liste.Add(_einkaufsliste.liste[i]);
            } 
        }
    }
}
