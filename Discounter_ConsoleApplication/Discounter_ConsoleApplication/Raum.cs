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
         /*   Console.WriteLine(GetType().ToString());
            Console.WriteLine(" Das Objekt hat folgende Eignschaften ");
            Console.WriteLine(" Bezeichnung: {0}\tFläche: {1}", bezeichnung, _flaeche);
            Console.WriteLine(" Hier können {0} Regale stehen ", anzahlRegale);
            Console.WriteLine(" Kunden sind {0} erlaubt", _kundenErlaubt ? "" : "nicht");
            Console.WriteLine(" Aus dem existierenden Warenkatalog wurde:"); */
            for(int i = x; i <= y; i++)
            {
                Regal regal = r[i];
                if(regal.aktuellerInhalt<1)
                {
                    Console.ForegroundColor = Red;
                }

              //   Display abbild = new Display();  //geht nicht weil static


                Display.darstellen();
             //   Console.WriteLine("Regal {0,3:D} : {1,4:D} Einheiten ", regal.regal_id, regal.aktuellerInhalt);
            //    Console.WriteLine("Das Regal hat einen Wert von {0} Euro\n", regal.aktuellerWarenwert);

            }
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
            { _regale[i] = new Regal(i, wk); }

            /*
            foreach(Regal r in _regale)
            {

                Console.WriteLine("Regal aufgestellt mit einer Kapazität: {0} Einheiten ", r.aktuellerInhalt);
                Console.WriteLine("Das Regal hat einen Wert von {0} Euro\n", r.aktuellerWarenwert);

            } */

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
