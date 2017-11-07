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



        // gibt den Umfang eine Rechtecks zurück
        public double umfang
        {
            get
            {
                return _umfang;
            }
            
        }

        public Rechteck(double b, double l)
        {
            _breite = b;
            _laenge = l;
            _umfang = 2 * (_breite + _laenge);  // hier steht nicht  value !!!!!!
        } 


    }
}