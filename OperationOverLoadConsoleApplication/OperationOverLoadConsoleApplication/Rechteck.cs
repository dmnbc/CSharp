using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationOverLoadConsoleApplication
{
    public class Rechteck : Figur
    {
        private double _breite;
        private double _laenge;
        private string _bepflanzung;

        public string bepflanzung
        {
            set
            {
                _bepflanzung = value;
            }
            get
            {
                return "Das Beet ist bepflanzt mit " + _bepflanzung;
            }
        }

        public double breite
        {
            get
            {
                return _breite;
            }

            set
            {
                _breite = value;
            }
        }

        public double laenge
        {
            get
            {
                return _laenge;
            }

            set
            {
                _laenge = value;
            }
        }

        public Rechteck(double b, double l)
        {
            _breite = b;
            _laenge = l;
            _umfang = 2 * (_breite + _laenge);  // hier steht nicht  value !!!!!!
            _flaeche = _breite * _laenge;
        }
        // typ der entsteht      welches Rechenzeichen   Beteiligten 
        public static Rechteck operator +(Rechteck r1, Rechteck r2)
        {

            Rechteck tmp = new Rechteck(0, 0);
            tmp._flaeche = r1.flaeche + r2.flaeche;
            tmp._umfang = r1.umfang + r2.umfang;
            return tmp;
        }
    }
}