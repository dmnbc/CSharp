using System;
using static System.Console;

namespace KlasseAbstrakt_ConsoleApplication
{
    class Program
    {

        class Klasse//nname immer groß
        {
            // Attribute oder Felder
            // ohne einen explizieten 'Zugriffsmodifizierer' ist alles
            // private und nicht ohne Methode erreichbar 

            int ganzZahl;
            string zeichenKette;

            // Methoden 
            public void zeigeAlles()
            {
                WriteLine("Das Objekt hat die Attribute :");
                WriteLine("{0}\t{1}", ganzZahl, zeichenKette);
            }

            // public setter um die private Attribute zu setzen 
            public void setze_ganzZahl_auf( int wert)
            {
                ganzZahl = wert; 
            }
            public void setze_zeichenKette_auf(string wert)
            {
                zeichenKette = wert;
            }

        }


        static void Main(string[] args)
        {
            // Objekt erzeugen oder Instanzieren
            // Klasse nennen und Objektname festlegen

            Klasse objekt = new Klasse();
            // wäre nur möglich, wenn public objekt.ganzZahl = 22;  //unerwünscht !!!!!
            objekt.setze_ganzZahl_auf(22);
            objekt.setze_zeichenKette_auf(" ist auch sehr schön ");

            objekt.zeigeAlles();

            ReadLine();
        }
    }
}
