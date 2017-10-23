using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscounterActor_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Actor.lfrNr = 0;


            Personal mi = new Personal();
            mi.Liste_zeigen();

            Dieb d = new Dieb();
            d.Liste_zeigen();

            Kunde k = new Kunde();
            k.Liste_zeigen();

            Console.ReadLine();
        }
    }
}
