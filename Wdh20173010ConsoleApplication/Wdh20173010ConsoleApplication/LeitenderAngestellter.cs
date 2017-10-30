using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wdh20173010ConsoleApplication
{
    public class LeitenderAngestellter : Angestellter
    {
        public static int gesamtAnzahlObjekte;
        private SortedList<int,int> meineMitarbeiterIDs = new SortedList<int,int>();
        public LeitenderAngestellter()
        {
            gesamtAnzahlObjekte++;
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("LeitenderAngestellter Basiskonstruktor gestartet");
            Console.WriteLine("Der Aufruf wurde ausgelöst von {0}", this.GetType());
            Console.ForegroundColor = temp;
        }

        public void inAbteilungEinstellen(int id)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            meineMitarbeiterIDs.Add(id,id);
            Console.WriteLine(" Der Mitarbeiter {0} wurde der Abteilung hinzugefügt", id);
            Console.ForegroundColor = temp;
        }

        public int wievieleMaHabIchDenn()
        {
            return meineMitarbeiterIDs.Count;
        }

        public void zeigeMeineMitarbeiter()
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (KeyValuePair<int, int> element in meineMitarbeiterIDs )
            {
                Console.WriteLine(" Der Mitarbeiter {0} gehört zu Abteilung ",element.Key);
            }
            Console.ForegroundColor = temp;
        }

        public override void ausbezahlen([System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
                [System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "",
                [System.Runtime.CompilerServices.CallerLineNumber] int sourceLineNumber = 0)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            base.ausbezahlen();
            Console.WriteLine("in {0}, aus {1} : Zeile {2} ", memberName, sourceFilePath, sourceLineNumber);
            Console.WriteLine("Der Lohn wird vollständig ausbezahlt");
            Console.ForegroundColor = temp;

        }
    }
}