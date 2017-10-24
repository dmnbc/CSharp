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

            Actor[] diverseIndividuen = new Actor[5];
            diverseIndividuen[0] = new Kunde();
            diverseIndividuen[1] = new Actor();
            diverseIndividuen[2] = new Dieb();
            diverseIndividuen[3] = new Kunde();
            diverseIndividuen[4] = new Personal();
           
            foreach(Actor betroffen in diverseIndividuen)
            {
                betroffen.wareEntnehmen();
                betroffen.bezahlen(); }
            Console.ReadLine();
        }
    }
}
