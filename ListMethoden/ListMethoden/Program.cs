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
                Console.WriteLine(" Momentangewicht {0} ", Momentangewicht());
                frachtliste.RemoveAt(frachtliste.Count() - 1);
                Console.WriteLine(" Momentangewicht nach dem Abladen {0} ", Momentangewicht());
            }

        public void beladen(double einzelStueckGewicht)
            {
                frachtliste.Add(einzelStueckGewicht);
                Console.WriteLine("Es wird ein weiteres Teil mit {0} Tonnen aufgeladen",einzelStueckGewicht);
                if(Momentangewicht() >= maxGewicht)
                {
                    Console.WriteLine("Das Fahrzeug wäre mit {0}  überladen!",Momentangewicht());
                    entladen();
                }
                else
                {
                    
                }
            }

            public double Momentangewicht()
            {
                foreach(double einzel in frachtliste)
                { momentanGewicht += einzel; }
                return momentanGewicht;
            }


        }
        static void Main(string[] args)
        {

            LKW_Ladung HH_M = new LKW_Ladung();
            HH_M.beladen(1.0);
            HH_M.beladen(2.0);
            HH_M.beladen(3.0);
            HH_M.beladen(2.0);
            HH_M.beladen(1.0);


            Console.ReadLine();
        }
    }
}
