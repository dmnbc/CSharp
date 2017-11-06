using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethoden
{
    class Program
    {
        // LKW kann 7.5 Tonnen laden
        class LKW_Ladung
        {
        private  List<double>  frachtliste = new List<double>(); // mit den einzelnen Gewichten
        private double maxGewicht = 7.5;
        private double momentanGewicht = 0;


        public void entladen() // letztes Teil wieder abladen
            {
                
                frachtliste.RemoveAt(frachtliste.Count() - 1);
                Ladeliste();
               
            }

        public void beladen(double einzelStueckGewicht)
            {
                
                Ladeliste();
                if(Momentangewicht()+einzelStueckGewicht <= maxGewicht)
                {
                    frachtliste.Add(einzelStueckGewicht);

                }
                else
                {
                    Console.WriteLine("Das letzte Frachtstück konnte wegen Überschreitung des Gesamtgewichts nicht geladen werden ");
                }


            }

            public double Momentangewicht()
            {
                momentanGewicht = 0;
                foreach (double einzel in frachtliste)
                { momentanGewicht += einzel; }
                return momentanGewicht;
            }

            public void Ladeliste()
            {
                int i = 0;
                Console.WriteLine("Aktuelle Ladeliste : ");
                foreach (double einzel in frachtliste)
                { Console.WriteLine("{0}\t{1}", i++, einzel); }
                Console.WriteLine("Gesamtgewicht dieser Frachtliste {0}", Momentangewicht());

            }


        }
        static void Main(string[] args)
        {

            LKW_Ladung HH_M = new LKW_Ladung();
           


            //   Aufgabe 
            // eingaben von Frachtstücken durch den Anwender

            // wenn Gesamtgewicht überschritten, soll er eine Angabe machen können,

            // entweder, welches Stück wieder abgelden wird.

            // oder  er nennt ein Gewicht, dass abgeladen werden soll.
            // entfernt werden soll dann ein Frachtstücke, dass mindestens x wiegt.






            Console.ReadLine();
        }
    }
}
