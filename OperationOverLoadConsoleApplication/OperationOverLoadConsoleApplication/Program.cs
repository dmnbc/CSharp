using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationOverLoadConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechteck blumenbeet = new Rechteck(10, 15) { bepflanzung = "Rosen" };
           
            Console.WriteLine("Der Zaun ums Blumenbeet ist {0} Meter lang", blumenbeet.umfang);
            Console.WriteLine(blumenbeet.bepflanzung);
            Console.ReadLine();
        }
    }
}
