using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToDelegateConsoleApplication
{
    public delegate void Del_anzeigen();

    class Program
    {

        static void Main(string[] args)
        {
            Del_anzeigen anzeigen = new Del_anzeigen(() => { });
            anzeigen += Controls.reactA;
            anzeigen += Controls.reactB;
            anzeigen += Controls.reactC;
            anzeigen();

            Console.ReadLine();

            anzeigen = new Del_anzeigen(() => { });
            anzeigen();

            Console.ReadLine();
        }
    }
}
