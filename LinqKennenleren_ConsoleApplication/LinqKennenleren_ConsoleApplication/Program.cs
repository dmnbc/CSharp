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
            double volKleiner = 0.01;
                     // Bereichsvariable art 
            var query = from art in Warenkatalog.warenkatalog where art.art_volumen < volKleiner select art;
            // SQL: result = select * form Warenkatalog.warenkatalog where art.art_volumen < .09
            foreach (var item in query )
            {
                Console.WriteLine(" Treffer bei Artikel {0} mit Volumen {1} ", item.art_id, item.art_volumen);
            }
             Console.WriteLine(" {0} Treffer mit Volumen kleiner {1}",query.Count(),volKleiner); // .Count wird nicht arbeiten
            warten();

            var mehrAls100Drin = from art in Warenkatalog.warenkatalog where 1.0/art.art_volumen > 100 select art;
            foreach (var item in mehrAls100Drin)
            {
                Console.WriteLine(" Treffer bei Artikel {0} mit Volumen {1} ", item.art_id, item.art_volumen);
            }
            Console.WriteLine(" {0} Treffer für Artikel mit mehr als 100 Einheiten im Regal", mehrAls100Drin.Count()); // .Count wird nicht arbeiten

            warten();
            var mehrAls100Wert = from art in Warenkatalog.warenkatalog where 1.0 / art.art_volumen*art.art_einzelpreis > 100 select art;
            foreach (var item in mehrAls100Wert)
            {
                Console.WriteLine(" Treffer bei Artikel {0} mit Anzahl {1} mal {2} = {3}", item.art_id, 1.0/item.art_volumen,item.art_einzelpreis, 1.0 / item.art_volumen*
                    item.art_einzelpreis);
            }
            Console.WriteLine(" {0} Treffer für Regale mit mehr als 100 Warenwert", mehrAls100Wert.Count()); // .Count wird nicht arbeiten

            warten();
            var wenigerAls100Wert = from art in Warenkatalog.warenkatalog where 1.0 / art.art_volumen * art.art_einzelpreis <= 100 select art;
            foreach (var item in wenigerAls100Wert)
            {
                Console.WriteLine(" Treffer bei Artikel {0} mit Anzahl {1} mal {2}", item.art_id, 1.0 / item.art_volumen, item.art_einzelpreis);
            }
            Console.WriteLine(" {0} Treffer für Regale mit unter 100 Wert",wenigerAls100Wert.Count()); // .Count wird nicht arbeiten

            warten();

            var volums = from art in Warenkatalog.warenkatalog select art.art_volumen;
            double avg = volums.Average();
            Console.WriteLine("Durchschnittliche Größe eines Artikeln {0,4:F2}", avg);
            warten();
        }
    }
}
