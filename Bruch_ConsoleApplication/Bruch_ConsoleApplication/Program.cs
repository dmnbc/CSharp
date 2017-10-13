using System;
using static System.Console;


namespace Bruch_ConsoleApplication
{
    class Program
    {
        class Bruch
        {
            int _zaehler, _nenner; // nenner darf nicht bei 0 bleiben
            double dezimalWert;  // kann hier nicht errechnet werden

            public void darstellen()
            {
                Write("{0}/{1} = {2,4:F3} ", _zaehler, _nenner,dezimalWert);
            }

            public int zaehler // hat keine ()
            {
                set //   setter für eine Property 
                {
                    _zaehler = value;
                    if( value != 0)
                    { dezimalWert = (double)_zaehler / _nenner; }
                    else
                    { dezimalWert = 0; }
                }

                get
                {
                    return _zaehler;
                }
            }
            public int nenner
            {
                set
                {
                    if (value != 0)
                    {
                        nenner = value;
                        dezimalWert = (double)_zaehler / _nenner;
                    }
                    else
                    { dezimalWert = 0;
                        WriteLine("Nenner = 0 ist nicht erlaubt !!"); }
                }
            }
        }


        static void Main(string[] args)
        {
            Bruch meinAnteilVomKuchen = new Bruch();
            meinAnteilVomKuchen.zaehler = 33; // ist wie .setze_zaehler(33)
            meinAnteilVomKuchen.nenner = 67;
            meinAnteilVomKuchen.darstellen();

            ReadLine();
        }
    }
}
