using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wdh20173010ConsoleApplication
{
    public abstract class Personal
    {
         public static int gesamtAnzahlObjekte;
         protected double entlohung;
        // Basiskonstruktor
       public Personal()  
        {
            gesamtAnzahlObjekte++;
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" --- Objekterstellung beginnt ------------------");
            Console.WriteLine("Personal Basiskonstruktor gestartet");
            Console.WriteLine("Der Aufruf wurde ausgelöst von {0}", this.GetType());
           
            Console.ForegroundColor = temp;
           
        }

        public virtual void ausbezahlen([System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Der Auszahlvorgang ist noch nicht spezifiziert");
            Console.ForegroundColor = temp;

        }
    }
}