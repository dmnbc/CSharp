using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discounter_ConsoleApplication
{
    internal class Regal
    {
        private int _regal_id;
        private double _volumen = 1;
        private Artikel _artikel;
        private int _kapazitaet;
        private int _mindestBestand;
        private bool _nachfuellen;
        private int _aktuellerInhalt;
        private double _aktuellerWarenwert;

        public int regal_id
        {
            get { return _regal_id;  }
        }

        public int aktuellerInhalt
        {
            get
            {
                return _aktuellerInhalt;
            }

            set
            {
                _aktuellerInhalt = value;
            }
        }

        public double aktuellerWarenwert
        {
            get
            {
                return _aktuellerWarenwert;
            }

            set
            {
                _aktuellerWarenwert = value;
            }
        }

        public int mindestbestand
        {
            get { return _mindestBestand; }
        }

        public bool nachfuellen
        {
            get
            {
                return _nachfuellen;
            }

            set
            {
                _nachfuellen = value;
            }
        }

        public int kapazität
            {
            get
            {
                return _kapazitaet;
            }

            }
        public Regal()
        {
            ConsoleColor tmp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Regal erstellt");
            Console.ForegroundColor = tmp;

        }

        public Regal(int id, Artikel[] wk, double vol)
        {
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Regal( id, wk, vol ) gestartet.");
                Console.ForegroundColor = tmp;

            }
            _regal_id = id;
            _volumen = vol;
            _artikel = new Artikel(_regal_id,wk);
            _kapazitaet = (int)(vol / _artikel.art_volumen);
            _mindestBestand =(int)( _kapazitaet * .8); // muss relativ zur Größe der Lagerregale bestimmt werden
            aktuellerInhalt = _kapazitaet;
            nachfuellen = aktuellerInhalt <= _mindestBestand;
            aktuellerWarenwert = aktuellerInhalt * _artikel.art_einzelpreis;
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Regal {0} mit {1} Einheiten aufgestellt. Nachfüllen bei weniger als {2}",
                    id,aktuellerInhalt,_mindestBestand);
                Console.ForegroundColor = tmp;
            }
        }
    }
}