using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    internal class Artikel
    {
        private int      _art_id;
        private double  _art_volumen;
        private double  _art_einzelpreis;

        public double art_einzelpreis
        {
            get
            {
                return _art_einzelpreis;
            }
        }

        public double art_volumen
        {
            get
            {
                return _art_volumen;
            }
        }

     

        public Artikel()
        {
          //  WriteLine("Artikel  angelegt:");
        }

        public Artikel(int id, Artikel[] wk)
        { // WriteLine("Artikel {0} angelegt: ", wk[id]._art_id);
            _art_id = wk[id]._art_id;
            _art_volumen = wk[id]._art_volumen;//1.0/((double)id*3);
            _art_einzelpreis = wk[id]._art_einzelpreis; // 1.0 / ((double) id * 5) ;
        //    WriteLine("Der Artikel hat ein Volumen von {0:F2} und einen Preis von {1:F2}", _art_volumen, _art_einzelpreis);
        }

   
        public Artikel(int id,double volumen, double preis)
        {
           // WriteLine("Artikel {0} angelegt: ", id);
            _art_id = id;
            _art_volumen = volumen;
            _art_einzelpreis = preis;
        }
        

    }

     class Program
    {
        static Artikel[] warenkatalog = new Artikel[]
          {
              new Artikel(0,0.015,.99),
              new Artikel(1,0.5,.99),
              new Artikel(2,0.25,.89),
              new Artikel(3,0.35,.79),
              new Artikel(4,0.15,.89),
              new Artikel(5,0.045,.49),
              new Artikel(6,0.25,.19),

          };

        static void Main(string[] args)
        {

            Regal[] verkaufsraum = new Regal[warenkatalog.Length]; 
            for (int id = 0; id < warenkatalog.Length; id++)
            { verkaufsraum[id] = new Regal(id, warenkatalog); }
           
                ReadLine();
            foreach (Regal r in verkaufsraum)
            { Console.Write("{0:D2}\t", r.aktuellerInhalt); }
            ReadLine();

            Verkauf v = new Verkauf();
            
            ReadLine();
        }
    }
}
