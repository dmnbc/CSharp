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



            Actor[] diverseIndividuen = new Actor[5];
            diverseIndividuen[0] = new Kunde();
            diverseIndividuen[1] = new Actor();
            diverseIndividuen[2] = new Dieb();
            diverseIndividuen[3] = new Kunde();
            diverseIndividuen[4] = new Personal();
           
            foreach(Actor betroffen in diverseIndividuen)
            { betroffen.bezahlen(); }
            Console.ReadLine();
        }
    }
}
