using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    class Actor
    {
        public struct zeile
        {
            int art;
            int anz;
            public zeile(int i, int j)
            {
                art = i;
                anz = j;
            }
        }
        static public int lfrNr;
        protected WasWieOft_Liste _einkaufsliste;
        protected WasWieOft_Liste _einkaufswagen;
        protected int id;
        protected string _rolle;

        public WasWieOft_Liste einkaufsliste
        {
            get {return _einkaufsliste;}
            set {  /* kann außerhalb nicht beschrieben werden */ }
        }

        public WasWieOft_Liste einkaufswagen
        {
            get {return _einkaufswagen;}
            set { _einkaufswagen = value;}
        }

        public string rolle
        { get { return _rolle; }
          set { _rolle = value; }
        }

        public Actor()
        {
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Basisklasse\nActor() startet:");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
            lfrNr++;
            _rolle = "Actor_Masterklassen_Objekt";
            _einkaufsliste = new WasWieOft_Liste();
            _einkaufswagen = new WasWieOft_Liste("einkaufswagen");
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Actor() endet:");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
        }  // end of default Konstruktor Actor()

        public void Liste_zeigen()
        {
            if (Program.TESTMODE)
            { ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Actor.Liste_zeigen() startet  -> _einkaufsliste.anzeigen()");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            _einkaufsliste.anzeigen();
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Actor.Liste_zeigen() endet nach -> _einkaufsliste.anzeigen()");
                Console.ForegroundColor = tmp;
            }
        }
                                  
        public virtual void bezahlen(       ref           Kasse           ks)
        {// Übergabe eines Objekts: call by reference Typ Kasse mit Namen ks  
            if (Program.TESTMODE)
            {   ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Actor.bezahlen (ref Kasse ks) wurde aufgerufen");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Da diese Methode virtual in der Masterklasse ist,\n" +
                                  "sollte diese Anzeige eigentlich nicht erfolgen.\n" +
                                  "Bitte prüfen Sie die Methoden in abgeleiteten Klassen");
                Console.ForegroundColor = tmp;
            }
        }
            
        public WasWieOft_Liste wareEntnehmen(Raum r)
        {                                      // zur Laufzeit kann r  Verkaufsraum und Lager darstellen
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Actor.wareEntnehmen(Raum r) startet ");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }                                   
            WasWieOft_Liste einkaufswagen = new WasWieOft_Liste("Einkaufswagen");
                                          // leerer Einkaufswagen
            for(int i = 0; i < _einkaufsliste.liste.Count;i++)
            {              //  Count: Länge der Einkaufsliste in Zeilen 
                if (Program.TESTMODE)
                { // Wiedergabe des Einkaufszettels 
                    ConsoleColor tmp = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Auf dem Zettel : Artikel {0,3} soll {1,3} mal gekauft werden", 
                    _einkaufsliste.liste[i].artikel, _einkaufsliste.liste[i].anzahl);
                    Console.ForegroundColor = tmp;
                }

                if (r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt >= _einkaufsliste.liste[i].anzahl)
                {                                                        // genug im Regal
                    if (Program.TESTMODE) { ConsoleColor tmp = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("genug da, von Liste in Einkaufswagen"); Console.ForegroundColor = tmp;
                    }
                    r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt -= _einkaufsliste.liste[i].anzahl;                    // einkaufswagen.liste.Add = // wunsch
                                                                          // Wunschmenge rausnehmen
                    einkaufswagen.liste.Add(_einkaufsliste.liste[i]);     // und in den Einkaufswagen legen
                    
                }
                else
                { // zu wenig im Regal, alles was noch da ist in den Einkaufswagen legen, Regal ist dann leer
                    if (Program.TESTMODE) { ConsoleColor tmp = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("zu wenig da, Regal wird leer gemacht");
                        Console.ForegroundColor = tmp; }
                    r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt = 0;
                    einkaufswagen.liste.Add(new WasWieOft_Liste.zeile(i, r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt));
                }
                r.regale[_einkaufsliste.liste[i].artikel].nachfuellen  // test auf ausreichende Restmenge, gibt bool zurück
                    = r.regale[_einkaufsliste.liste[i].artikel].aktuellerInhalt <= r.regale[_einkaufsliste.liste[i].artikel].mindestbestand;
            }
            if (Program.TESTMODE) {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Im Wagen sind {0} verschiedene Artikel,\nActor.wareEntnehmen(Raum r) endet ", einkaufswagen.liste.Count);
                Console.ForegroundColor = tmp;
            }
            return einkaufswagen;   // Rückgabe der entnommenen Artikel als WasWieOft_Liste  im Einkaufswagen
        }
    }
}
