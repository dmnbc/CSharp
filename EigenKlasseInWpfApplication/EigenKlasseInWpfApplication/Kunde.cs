using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;         // wegen der Verwendung von Image
using System.Windows.Media.Imaging;

namespace EigenKlasseInWpfApplication
{
    class Kunde
    {
        public static int kundenummer;
        public Image wagen = new Image();      // WPFKlasse in normaler .cs Umgebung verwenden 

        public Kunde()
        {
            kundenummer++;
            wagen.Source = 
                new BitmapImage(new Uri("D:\\D\\_freiberuflich\\github\\csharp\\beispieldateien\\EigenKlasseInWpfApplication\\EigenKlasseInWpfApplication\\shopping-cart.png"));
        }
    }
}
