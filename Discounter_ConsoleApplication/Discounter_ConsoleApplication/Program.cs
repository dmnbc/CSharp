using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounter_ConsoleApplication
{
    class Artikel
    {
        private int      _art_id;
        private double  _art_volumen;
        private double  _art_einzelpreis;

        public Artikel()
        {
          //  WriteLine("Artikel  angelegt:");
        }

        public Artikel(int id, Artikel[] wk)
        { WriteLine("Artikel {0} angelegt: ", wk[id]._art_id);
            _art_id = wk[id]._art_id;
            _art_volumen = wk[id]._art_volumen;//1.0/((double)id*3);
            _art_einzelpreis = wk[id]._art_einzelpreis; // 1.0 / ((double) id * 5) ;
            WriteLine("Der Artikel hat ein Volumen von {0:F2} und einen Preis von {1:F2}", _art_volumen, _art_einzelpreis);
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
              new Artikel(1,0.5,.99),
              new Artikel(2,0.25,.89),
              new Artikel(3,0.35,.79),
              new Artikel(4,0.15,.89),
              new Artikel(5,0.45,.49),

          };

        static void Main(string[] args)
        {
            
            for (int id = 0; id < warenkatalog.Length; id++)
            { Artikel temp = new Artikel(id, warenkatalog); }
           
                ReadLine();
        }
    }
}
