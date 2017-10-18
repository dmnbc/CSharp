using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    internal class Raum
    {
        protected int _anzahlRegale;
        protected string _bezeichnung;
        protected double _flaeche;
        protected bool _kundenErlaubt;
        protected Regal[] _regale;

        public Raum()
        {
           
        }

        public Raum(string b, double f)
        {
            bezeichnung = b;
            _flaeche = f;
            
        }

        public int anzahlRegale
        {
            get
            {
                return _anzahlRegale;
            }

            set
            {
                _anzahlRegale = value;
            }
        }

        public string bezeichnung
        {
            get
            {
                return _bezeichnung;
            }
            set
            {
                _bezeichnung = value;
            }
        }

        public void anzeigen()
        {
            Console.WriteLine(GetType().ToString());
            Console.WriteLine(" Das Objekt hat folgende Eignschaften ");
            Console.WriteLine(" Bezeichnung: {0}\tFläche: {1}",bezeichnung,_flaeche);
            Console.WriteLine(" Hier stehen {0} Regale ",anzahlRegale);
            Console.WriteLine(" Kunden sind {0} erlaubt", _kundenErlaubt ? "" : "nicht");
        }
    }
    internal class Verkauf:Raum
    {
        private int _anzahlKunden;

        public Verkauf()
        {
            
        }

        public Verkauf(string b,double f):base(b,f)
        {
            _kundenErlaubt = true;
            anzahlRegale = (int)(f / .5);
            

        }



        public int anzahlKunden
        {
            get
            {
                return _anzahlKunden;
            }

            set
            {
            }
        }
    }
    internal class Lager : Raum
    {
        public Lager()
        {
            
        }
        public Lager(string b,double f):base(b,f)
        {
            _kundenErlaubt = false;
            anzahlRegale = (int)(f / .33);
            
        }
    }



    
}
