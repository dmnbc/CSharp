using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Abgeleitet a1 = new Abgeleitet();
            ((IAnzeige)a1).Anzeige("Ich habe implementiert");

            Console.ReadLine();

            AbgeleitetVonAbgeleitet aVona = new AbgeleitetVonAbgeleitet();
            ((IAbzaehlen)aVona).Anzeige("Ich habe das Interface von meiner Masterklasse geerbt");

            Console.ReadLine();
            AbgeleitetVonAndereAbleitung aVonaA = new AbgeleitetVonAndereAbleitung();
            
           List<int> intList = new List<int>
            Console.ReadLine();
        }
    }
}
