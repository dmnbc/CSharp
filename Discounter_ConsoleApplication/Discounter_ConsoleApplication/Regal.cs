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
        public Regal()
        {

        }

        public Regal(int id, Artikel[] wk)
        {
            _regal_id = id;
            _artikel = new Artikel(_regal_id,wk);
            _kapazitaet = (int)(_volumen / _artikel.art_volumen);
            _mindestBestand =(int)( _kapazitaet * .3);
            aktuellerInhalt = _kapazitaet;
            nachfuellen = aktuellerInhalt > _kapazitaet;
            aktuellerWarenwert = aktuellerInhalt * _artikel.art_einzelpreis;

            Console.WriteLine("Regal {0} aufgestellt mit einer Kapazität: {1} Stück ",_regal_id, _kapazitaet);
            Console.WriteLine("Das Regal hat einen Wert von {0} Euro\n", aktuellerWarenwert);
        }
    }
}