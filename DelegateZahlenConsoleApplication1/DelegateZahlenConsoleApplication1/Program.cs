using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateZahlenConsoleApplication1
{
    class Program
    {
        public delegate void Del_zahlen(int  i);
        // Delegatenbeschreibung, die mit int als Parameter, Methode nutzt
        // , die nichts zurückgeben

        static void Main(string[] args)
        {
            Del_zahlen zahlenVerarbeitung;  // ein Objekt vom Typ Delegat Del_zahlen
                                            // kann also die Adresse von Methoden aufnehmen
                                            // die void   ( int )  signiert sind.
            zahlenVerarbeitung = new Del_zahlen(Zahlen.verdoppeln);
            zahlenVerarbeitung += new Del_zahlen(Zahlen.quadrieren);
            zahlenVerarbeitung += new Del_zahlen(Zahlen.halbieren);
            zahlenVerarbeitung += new Del_zahlen(Zahlen.wurzeln);

            // eine Methode hinzufügen, die noch nicht angelegt ist
            zahlenVerarbeitung += new Del_zahlen((int i) => { Console.WriteLine("so, dieses auch noch");});

            // in zahlenVerarbeitung ist jetzt die Aufrufadresse
            // von Zahlen.verdoppeln

            // und jetzt endlich, der Abruf
            zahlenVerarbeitung(42);
            Console.ReadLine();
            zahlenVerarbeitung -= new Del_zahlen(Zahlen.halbieren); // wieder rausnehmen
            zahlenVerarbeitung(42);

            Console.ReadLine();


        }

        class Zahlen
        {   // Die Refernzierten Methode für den Delegaten
            // als wiederverwendbare statics 

            public static void verdoppeln( int x)
            {
                Console.WriteLine("Das Doppelte von {0} ist {1} ", x, x * 2);
            }
            public static void halbieren(int x)
            {
                Console.WriteLine("Die Hälfte von {0} ist {1} ", x, x / 2);
            }
            public static void quadrieren(int x)
            {
                Console.WriteLine("Das Quadrat von {0} ist {1} ", x, x * x);
            }

            public static void wurzeln( int d )
            {
                Console.WriteLine("Die Wurzel von {0} ist {1} ", d, Math.Sqrt(d).ToString());
            }

        }
    }
}
