using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationOverLoadConsoleApplication
{
    public class Kreis : Figur
    {
        private double _radius;

        public Kreis(double r)
        {
            _radius = r;
            _umfang = 2 * r * Math.PI;
            _flaeche = Math.PI *Math.Pow(r,2);

        }
       
        public double radius
        {
            get
            {
                return _radius;
            }
        }

        public static Kreis operator +( Kreis k1, Kreis k2)
        {
            double gesamtflaeche = k1.flaeche + k2.flaeche;
            double r = Math.Sqrt (gesamtflaeche / Math.PI);

            return new Kreis(r); 
        }

    }
}