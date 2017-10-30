using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wdh20173010ConsoleApplication
{
    public class TarifgebundenerAngestellter : Angestellter
    {
        public static int gesamtAnzahlObjekte;
        public TarifgebundenerAngestellter()
            // hat auch eine int id von Basis erhalten
        {
            gesamtAnzahlObjekte++;
            id = Angestellter.gesamtAnzahlObjekte;
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("TarifgebundenerAngestellter Basiskonstruktor gestartet");
            Console.WriteLine("Der Aufruf wurde ausgelöst von {0}", this.GetType());
            Console.ForegroundColor = temp;
        }

        public override void ausbezahlen([System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.ausbezahlen();
            Console.WriteLine("Vom Lohn wird der Krankenkassenbeitrag abgezogen");
            Console.ForegroundColor = temp;

        }
    }
}