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
/*
            var queryDatenAusCSV = from csvZeile in File.ReadAllLines("plz.csv")
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
*/
            var alleOrte =  (from orte in
                             from
                             csvZeile in File.ReadAllLines("plz.csv")
                             let ortsdaten = csvZeile.Split(',') where ortsdaten[2].Contains("haus") &&  ortsdaten[6] == "\"Bayern\""
                             select new
                             {
                                 id  = ortsdaten[0],
                                 plz = ortsdaten[1],
                                 ort = ortsdaten[2],
                                 kreisnr    = ortsdaten[3],
                                 kreisname  = ortsdaten[4],
                                 landnr     = ortsdaten[5],
                                 bundesland = ortsdaten[6]
                             } orderby orte.ort select orte.ort).Distinct();

            foreach (var item in alleOrte)
            {
                Console.WriteLine(item);
            }

            warten();

        }
    }
}
