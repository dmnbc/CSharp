using System;
using System.Collections.Generic;
using System.Linq; // wird benötigt
using System.Text;
using System.Threading.Tasks;

namespace LinqKennenleren_ConsoleApplication
{
    class Program
    {
        static void warten()
        {
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Warenkatalog wk = new Warenkatalog();

         //   var query = from art in Warenkatalog.warenkatalog where art.art_volumen < .09 select art;
            var query = from art in Warenkatalog.warenkatalog where art.art_volumen < .04 select art;

            // SQL: result = select * form Warenkatalog.warenkatalog where art.art_volumen < .09
            foreach (var item in query )
            {
                Console.WriteLine(" Treffer bei Artikel {0} mit Volumen {1} ", item.art_id, item.art_volumen);
            }
             Console.WriteLine(" {0} Treffer",query.Count()); // .Count wird nicht arbeiten
            warten();


        }
    }
}
