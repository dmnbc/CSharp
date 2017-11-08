using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_ConsoleApplication1
{
    public class Abgeleitet : IAnzeige, IAbzaehlen
    {
         void IAbzaehlen.Anzeige(string s)
        {
            Console.WriteLine("Anzeige Methode aus IAbzaehlen : {0} ",s); 
        }

         void IAbzaehlen.Entladen()
        {
            throw new NotImplementedException();
        }

        void IAnzeige.Anzeige(string s)
        {
            Console.WriteLine("Die Anzeige : {0}",s);
        }
             

         void IAnzeige.Entladen()
        {
            throw new NotImplementedException();
        }

       
    }
}