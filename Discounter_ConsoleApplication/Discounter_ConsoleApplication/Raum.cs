using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ConsoleColor;

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

        public Regal[] regale
        {
            get
            {
                return _regale;
            }
           
        }

        public void anzeigen(Regal[] r)
        {anzeigen(r, 0, r.Length-1);}

        public void anzeigen(Regal[] r, int x)
        {anzeigen(r, x, x);}

        public void anzeigen(Regal[] r,int x, int y)
        {
          Display.darstellen(ref r,x,y );
            
        }
    }
    internal class Verkauf:Raum
    {
        private int _anzahlKunden;

        public Verkauf()
        {
            
        }

        public Verkauf(string b,double f,ref Artikel[] wk):base(b,f)
        {
            _kundenErlaubt = true;
            anzahlRegale = (int)(f / .5);
            _regale = new Regal[wk.Length];
            for (int i = 0; i < wk.Length /*anzahlRegale */; i++)
            { _regale[i] = new Regal(i, wk, 1.0); }

            Console.WriteLine("Verkauf erstellt");
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
        public Lager(string b,double f, ref Artikel[] wk) :base(b,f)
        {
            _kundenErlaubt = false;
            anzahlRegale = 800; // noch durch Formel bestimmen lassen
            _regale = new Regal[wk.Length];
            for (int i = 0; i < wk.Length /*anzahlRegale */; i++)
            { _regale[i] = new Regal(i, wk, .33); }
            Console.WriteLine("Lager erstellt");

        }
    }



    
}
