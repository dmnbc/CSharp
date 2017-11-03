using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvVerarbeitung_ConsoleApplication
{
    class Program
    {
        public static void warten()
        {
            Console.WriteLine("Weiter mit ┘ "); 
            Console.ReadLine();
        }


        static void Main(string[] args)
        {

            // Abfragen ( LINQ ) an die csv-Datei richten 

            var query = from csvZeile in File.ReadAllLines("plz.csv")
            let ortsdaten = csvZeile.Split(',')
                        select new
                        {
            id = ortsdaten[0],
            plz= ortsdaten[1],
            ort= ortsdaten[2],
            kreisnr = ortsdaten[3],
            kreisname = ortsdaten[4],
            landnr = ortsdaten[5],
            bundesland = ortsdaten[6]
        };

            foreach(var item in query)
            {
                Console.WriteLine("Orte mit Postleitzahlen : {0} \t {1}",item.ort,item.plz );
            }

            // alle vorhandenen Orte nennen,
            
        /*                   var alleOrte = (from orte in meineDaten.ortsangaben orderby orte.ort select orte.ort).Distinct();
                        //     var alleOrte = (from orte in meineDaten.ortsangaben select orte.ort).Distinct().OrderBy( x => x);
                        foreach ( var item in alleOrte)
                        {
                            Console.WriteLine(item);
                        }

    */
            
            warten();

        }
    }
}
