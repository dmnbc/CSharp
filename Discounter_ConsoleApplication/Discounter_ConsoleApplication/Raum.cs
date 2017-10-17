using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    internal class Raum
    {
        protected string _raum_bezeichnung;
        protected int _raum_flaeche;  // in quadratmeter
        protected static int _raum_kapazitaet;
        protected Regal[] regal = new Regal[_raum_kapazitaet];

        public Raum()
        { }

        public Raum(string rb, int f)
        {

        }
    }
     internal class Verkauf:Raum
        {
         public  Verkauf()
        {
            _raum_bezeichnung = "Ladenfläche"; ;
        }
        }
     internal class Lager : Raum
        {

        }



    
}
