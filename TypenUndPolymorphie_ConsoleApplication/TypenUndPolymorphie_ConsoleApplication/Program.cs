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
            Console.WriteLine("------------------");
            Ableitung myDerivat = new Ableitung(55);
            Console.WriteLine("Wert des Attributes: {0}",myDerivat.Ganzzahlbeschaffer());
            WeitereAbleitung anotherDerivat = new WeitereAbleitung(19);
            Console.WriteLine("Wert des Attributes: {0}", anotherDerivat.Ganzzahlbeschaffer());
            Console.WriteLine("------------------");
            // Ein Array mit gemischten Objekten aus 
            // allen drei Klassen

            object[] alleZusammen = new object[5];
            Console.WriteLine("Das Array ist {0} lang", alleZusammen.Length);
            alleZusammen[0] = new Wurzel(99);
            alleZusammen[1] = new Ableitung(11);
            alleZusammen[2] = new WeitereAbleitung(22);
            alleZusammen[3] = new Wurzel(33);
            alleZusammen[4] = new Ableitung(44);
            Console.WriteLine("Das erste Element im Array {0}", alleZusammen[0]);
            Console.WriteLine("Das zweite Element im Array {0}", alleZusammen[1]);
            Console.WriteLine("Das dritte Element im Array {0}", alleZusammen[2]);
            Console.WriteLine("Das vierte Element im Array {0}", alleZusammen[3]);
            Console.WriteLine("Das letzte Element im Array {0}", alleZusammen[4]);
            Console.WriteLine("------------------");

            foreach(Wurzel  var in alleZusammen)
            {
                Console.WriteLine("Typ des Elements {0}", var);
                Console.WriteLine("darin gekapselte Ganzzahl : {0}",var.Ganzzahl);
                var.normalVerhalten();
            }



            Console.ReadLine();
        }
    }
}
