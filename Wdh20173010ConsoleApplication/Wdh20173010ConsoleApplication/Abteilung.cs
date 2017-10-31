using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wdh20173010ConsoleApplication
{
    public class Abteilung
    {
        public LeitenderAngestellter chef;
        public string nameChef = new string(new char[] {'B', '\u2202', 's', 's'});

       public Abteilung(LeitenderAngestellter boss)
        {
            chef = boss;
        }
}
}