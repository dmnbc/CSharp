using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spezialisierung_ConsoleApplication
{
    class Program
    {

        class Eltern
        {   // geht als privat an die 'erbende' Klasse
            protected string familienname;
            string wohnort;
            string vorname_mutter;
            string vorname_vater;

            // Konstruktor mit Signatur 4 mal string 
           public Eltern(string fn,  string w, string vmutter, string vvater)
            {
                familienname=fn;
                wohnort=w;
                vorname_mutter=vmutter;
                vorname_vater=vvater;
            }

            public Eltern()
            {
               //  Console.WriteLine("Wir sind die Eltern");
            }

            public void allesZeigen()
            {
                Console.WriteLine("Alle Daten ausgeben");
            }
        }
                        // geht nur , wenn es den Konstruktor() gibt
        class Nachkommen : Eltern
        {
            public int alter;
            public string fn;
           

            public Nachkommen()
            {    // umkopieren in eine public der erbenden Klasse
                fn = familienname;
            }
        }


        static void Main(string[] args)
        {
            // Deklaration             Instanzieren
            // Eltern dieEltern = new Eltern("Meier","Köln","Maria","Karl");
            Nachkommen dePänz = new Nachkommen();
            dePänz.allesZeigen();
            Console.ReadLine();
        }
    }
}
