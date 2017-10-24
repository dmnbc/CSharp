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
        }

        // 'klassische' Variante zum getter 
        public int Ganzzahlbeschaffer()
        {
            return gekapselteGanzzahl; 
        }

    }
}
