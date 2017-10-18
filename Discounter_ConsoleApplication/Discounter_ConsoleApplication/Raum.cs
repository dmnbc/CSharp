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
            throw new System.NotImplementedException();
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
    }
    internal class Verkauf:Raum
    {
        private int _anzahlKunden;

        public Verkauf()
        {
            throw new System.NotImplementedException();
        }

        public int anzahlKunden
        {
            get
            {
                throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }



    
}
