using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MannschaftWpfApplication
{
    class Bilder
    {
        public static List<string> bilderSource = new List<string>();
        private string pfad = "D:\\D\\_freiberuflich\\github\\csharp\\beispieldateien\\MannschaftWpfApplication\\MannschaftWpfApplication\\";
        public Bilder()
        {
            bilderSource.Add(pfad+"10435.jpg");    // neuer
            bilderSource.Add(pfad + "2419.jpg");   //lahm
            bilderSource.Add(pfad + "4711.jpg");  //
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "0815.jpg");  // robben
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
            bilderSource.Add(pfad + "4711.jpg");
        }
    }
}
