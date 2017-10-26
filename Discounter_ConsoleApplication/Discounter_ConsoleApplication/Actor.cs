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

            public zeile(int i, int j)
            {
                art = i;
                anz = j;
            }
        }
        static public int lfrNr;
        protected Einkaufszettel _einkaufsliste;
        protected Einkaufszettel _einkaufswagen;
        protected int id;
        protected int rolle;

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
                _einkaufswagen = value;
            }
        }

        public Actor()
        {
            lfrNr++;
            _einkaufsliste = new Einkaufszettel();
            _einkaufswagen = new Einkaufszettel("einkaufswagen");
            
            Console.WriteLine("Es wurde zuerst ein Einkaufszettel erstellt");

        }

        ~Actor()
        {
            
        }

        public void Liste_zeigen()
        {
            _einkaufsliste.anzeigen();
        }
                                  // Verweis auf ein Objekt vom Typ Kasse mit Namen ks
        public virtual void bezahlen(ref Kasse ks) //  in C   Kasse &ks
        {
            Console.WriteLine("Der Actor zahlt für");
           // this.Liste_zeigen();
        }

      //  public void wareEntnehmen(Discounter_ConsoleApplication.Raum r)
        public Einkaufszettel wareEntnehmen(Discounter_ConsoleApplication.Raum r)
        {
            Einkaufszettel einkaufswagen = new Einkaufszettel("Einkaufswagen");
            for(int i = 0; i < _einkaufsliste.liste.Count;i++)
            {
                 Console.WriteLine(" Auf dem Zettel : Artikel {0,3} soll {1,3} mal gekauft werden", _einkaufsliste.liste[i].artikel, _einkaufsliste.liste[i].anzahl);
                if (r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt >= _einkaufsliste.liste[i].anzahl)
                { // genug im Regal
                    Console.WriteLine("genug da");
                    r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt -= _einkaufsliste.liste[i].anzahl;                    // einkaufswagen.liste.Add = // wunsch
                    einkaufswagen.liste.Add(_einkaufsliste.liste[i]);
                }
                else
                { // zu wenig im Regal, alles was noch da ist
                    Console.WriteLine("zu wenig da, Regal wird leer gemacht");
                    einkaufswagen.liste.Add(new Einkaufszettel.zeile(i, r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt));
                    r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt = 0;
                }
                 r.regale[_einkaufsliste.liste[i].artikel].nachfuellen = r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt <= r.regale[_einkaufsliste.liste[i].artikel].mindestbestand;
            }
            Console.WriteLine("Im Wagen sind {0} verschiedene Artikel ", einkaufswagen.liste.Count);
            return einkaufswagen;   // wegen Änderung der Rückgabe von void auf Einkaufszettel
        }
    }
}
