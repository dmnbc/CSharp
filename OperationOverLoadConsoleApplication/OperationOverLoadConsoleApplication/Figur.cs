using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationOverLoadConsoleApplication
{
    public class Figur
    {
        protected double _umfang;
        protected double _flaeche;


        public double umfang
        {
            get
            {
                return _umfang;
            }
        }
        public double flaeche
        {
            get
            {
                return _flaeche;
            }
        }
    }
}