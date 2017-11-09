using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricsConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellipse ely = new Ellipse(10,10);
            ely.Anzeige();
            Kreis krei = new Kreis(20, 12);
            krei.Anzeige();
            Dreieck dre = new Dreieck(2, 2);
            dre.Anzeige();
            Rechteck rech = new Rechteck(5, 0);
            rech.Anzeige();
            Trapez tra = new Trapez(1, 8);
            tra.Anzeige();
            Quadrat qua = new Quadrat(12, 5);
            qua.Anzeige();
            Console.ReadLine();
            tra = new Trapez(tra.Verschieben(-11,-3).Key, tra.Verschieben(-11,-3).Value);
            tra.Anzeige();
            qua = new Quadrat(qua.Verschieben(3, 10).Key, qua.Verschieben(3, 10).Value );
            qua.Anzeige();
            
            Console.ReadLine();

        }
    }
}
