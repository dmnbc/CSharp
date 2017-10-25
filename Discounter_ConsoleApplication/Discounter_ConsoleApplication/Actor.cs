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
            Console.WriteLine("Es wurde zuerst ein Einkaufszettel erstellt");

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
           // this.Liste_zeigen();
        }

        public void wareEntnehmen()
        {
            Einkaufszettel einkaufswagen = new Einkaufszettel("Einkaufswagen");
            for(int i = 0; i < _einkaufsliste.liste.Count;i++)
            {
 
                Console.WriteLine(" Auf dem Zettel : Artikel {0,3} soll {1,3} mal gekauft werden", _einkaufsliste.liste[i].artikel, _einkaufsliste.liste[i].anzahl);
                //            if(  >  )
                //             { // genug im Regal

                // einkaufswagen.liste.Add = // wunsch
                // Verkauf[xx].   -= wunsch;
                //              }
                //              else
                //              { // zu wenig im Regal, alles was noch da ist
                // einkaufswagen.liste. = // Verkauf[xx].
                // Verkauf[xx].   = 0;
                //     
                Console.WriteLine("Im Wagen lfdNr: {0},ArtikelNr:{1}, Anzahl:{2}", i, _einkaufsliste.liste[i].artikel, _einkaufsliste.liste[i].anzahl);
               

                einkaufswagen.liste.Add(_einkaufsliste.liste[i]);
            }
            Console.WriteLine("Im Wagen sind {0} verschiedene Artikel ", einkaufswagen.liste.Count);          
        }
    }
}
