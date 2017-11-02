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
            Console.WriteLine("Weiter mit ┘ ");
            Console.ReadLine();
        }

        static int verdopple( int i)
        {
            return i * 2;
        }
        static void Main(string[] args)
        {
            Warenkatalog wk = new Warenkatalog();
            //    foreach( Artikel item in wk)  braucht immer Enumerable  Daten 
            /*      for(int i = 0; i < Warenkatalog.warenkatalog.Length; i++)
                      {
                          Console.WriteLine("{0}\t{1}\t{2}",
                                  Warenkatalog.warenkatalog[i].art_id, 
                                  Warenkatalog.warenkatalog[i].art_volumen, 
                                  Warenkatalog.warenkatalog[i].art_einzelpreis);
                      }

                      // in SQL :    select * from Warenkatalog.warenkatalog  
                      //                               Quelle  /  Table 
                     var artikelliste = from artikel in Warenkatalog.warenkatalog select artikel;    // in LINQ Syntax



                      foreach (var item  in artikelliste)
                      {
                          Console.WriteLine("{0}\t{1}\t{2}", 
                              item.art_id,
                              item.art_volumen,
                              item.art_einzelpreis);
                      }
                      warten();
            //      in SQL: select volumen  from Warenkatalog.warenkatalog
            var artikelvolumen = from artikel in Warenkatalog.warenkatalog select artikel.art_volumen;    // in LINQ Syntax



            foreach (var item in artikelvolumen)
            {
                Console.WriteLine("{0}",item  );
            }*/
            warten();
            // Select mit berechnetem Ergebnis aus einer Spalte 
            var artikelImRegal = from artikel in Warenkatalog.warenkatalog select (int)(1.0/artikel.art_volumen);    // in LINQ Syntax



            foreach (var item in artikelImRegal)
            {
                Console.WriteLine("{0}",item);
            }
            
           warten();

            // Select mit berechnetem Ergebnis aus mehreren  Spalten 
            var Regalwert = from artikel in Warenkatalog.warenkatalog select ((int)(1.0 / artikel.art_volumen))*artikel.art_einzelpreis;    // in LINQ Syntax



            foreach (var item in Regalwert)
            {
                Console.WriteLine("{0}", item);
            }

            warten();

            // Select mit berechnetem Ergebnis aus mehreren  Spalten und einer Spalte, wie AS in SQL 
            var idUndRegalwert = from artikel in Warenkatalog.warenkatalog select new { id=artikel.art_id,
                                                                                        wert = ((int)(1.0 / artikel.art_volumen)) * artikel.art_einzelpreis
                                                                                      };    // in LINQ Syntax



            foreach (var item in idUndRegalwert)
            {
                Console.WriteLine("Regal {0} hat den Wert \t{1,4:F2}", item.id, item.wert);
            }

            warten();




        }
    }
}
