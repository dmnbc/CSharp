using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypenUndPolymorphie_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Wurzel myRoot = new Wurzel();
            Wurzel anotherRoot = new Wurzel(42);
            Console.WriteLine("Das Objekt hat die Eigenschaft gekapselteganzzahl = {0}",anotherRoot.Ganzzahl);
            // anotherRoot.Ganzzahl = 33;
            Console.WriteLine("Das Objekt hat die Eigenschaft gekapselteganzzahl = {0}", anotherRoot.Ganzzahlbeschaffer());

            Console.ReadLine();
        }
    }
}
