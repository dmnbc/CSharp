using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wdh20173010ConsoleApplication
{
    public abstract  class Angestellter : Personal
    {
        public static int gesamtAnzahlObjekte;
        protected     int id;  // wird vererbt an alle Folgeklassen 
        public Angestellter()
        {
            gesamtAnzahlObjekte++;
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Angestellter Basiskonstruktor gestartet");
            Console.WriteLine("Der Aufruf wurde ausgelöst von {0}", this.GetType());
            
            Console.ForegroundColor = temp;
        }

        public int id_lesen
        {
            get
            { return id; }
        }

        public override void ausbezahlen([System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("in {0}, aus {1} : Zeile {2} ", memberName, sourceFilePath, sourceLineNumber);
            Console.WriteLine("Der Auszahlvorgang wird per Überweisung durchgeführt");
            Console.ForegroundColor = temp;

        }
    }
}