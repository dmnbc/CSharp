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

            public void entladen(int i) // bestimmtes Teil wieder abladen
            {

                frachtliste.RemoveAt(i);
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
                    Console.WriteLine("Das letzte Frachtstück kann wegen Überschreitung des Gesamtgeichts nicht aufgeladen werden.");
                    Console.WriteLine("Wollen Sie dafür ein anderes Teil abladen lassen?");
                    Console.WriteLine("Sie können den Index des Frachtstückes als Ganzzahl angeben ");
                    Console.WriteLine("Oder eine Zahl mit Komma, die das zu entfernende Gewicht angibt");

                    int eingabeIndex;
                    string input;
                    input = Console.ReadLine();
                    if (int.TryParse(input, out eingabeIndex))
                        {
                        Console.WriteLine("Das Frachstück index {0} wird abgeladen", eingabeIndex);
                        frachtliste.RemoveAt(eingabeIndex);
                    }
                    else
                    {
                        double eingabeGewicht;
                        double.TryParse(input, out eingabeGewicht);
                        Console.WriteLine("Es wird ein Frachstück mit mehr als {0} Tonnen abgeladen", eingabeGewicht);
                        int foundAT = -1;
                        int index = 0;
                        bool someThingFound = false;
                        foreach (double gewicht in frachtliste)
                        { if (gewicht >= eingabeGewicht)
                            {
                                foundAT = index;
                                someThingFound = true;
                            }
                            if (someThingFound) { break; }
                            index++;
                        }
                        frachtliste.RemoveAt(foundAT);
                    }
                    frachtliste.Add(einzelStueckGewicht);
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
            double eingabe;

            Console.WriteLine("Bitte geben Sie die Gewichte Ihrer Frachtstücke an");
            Console.WriteLine("Um die Eingabe zu beenden, geben Sie 'Ende' ein");


            while ( double.TryParse(Console.ReadLine(),out eingabe))
            {
                HH_M.beladen(eingabe);
                HH_M.Ladeliste();
            }

            //   Aufgabe 
            // eingaben von Frachtstücken durch den Anwender

            // wenn Gesamtgewicht überschritten, soll er eine Angabe machen können,

            // entweder, welches Stück wieder abgeladen wird.

               // RemoveAt()    

            // oder  er nennt ein Gewicht, dass abgeladen werden soll.
            // entfernt werden soll dann ein Frachtstücke, dass mindestens x wiegt.

              // Remove( gewicht )  






            Console.ReadLine();
        }
    }
}
