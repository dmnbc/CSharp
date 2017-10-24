using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypenUndPolymorphie_ConsoleApplication
{
    class Wurzel
    {
        public int  ganzzahl;
        private int gekapselteGanzzahl;

        public Wurzel()
        {
            Console.WriteLine("Es wurde der Konstruktor Wurzel() aufgerufen");
            Console.WriteLine("Der Auslöser des Aufrufes war ein Objekt vom");
            Console.WriteLine(this); // this ist Zeiger auf das aufrufende Objekt
        }

        public Wurzel(int parameter)
        {
            gekapselteGanzzahl = parameter;
            Console.WriteLine("Es wurde der Konstruktor Wurzel({0}) aufgerufen",gekapselteGanzzahl);
        }

        public int Ganzzahl
        {
            get
            {
                return gekapselteGanzzahl;
            }
            set
            {
                gekapselteGanzzahl = value; 
            }
        }

        // 'klassische' Variante zum getter 
        public int Ganzzahlbeschaffer()
        {
            return gekapselteGanzzahl; 
        }

        public virtual void normalVerhalten()
        {
            Console.WriteLine("Ich bin ganz toll ");
            aber();
        }

        private void aber()
        {
            Console.WriteLine(", aber ....");
        }

    }
}
