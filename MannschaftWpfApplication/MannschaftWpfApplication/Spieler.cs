using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MannschaftWpfApplication
{
    class Spieler
    {
        public static int lfd_nr;
        public Image bild = new Image();
        public int rueckennummer;
        public int row, col;
        public  Spieler()
        {
            rueckennummer = lfd_nr++;
            bild.Source = new BitmapImage(new Uri(Bilder.bilderSource[rueckennummer-1]));


            switch (rueckennummer)
            {
                case 1: row = 0;
                        col = 3;
                    break;
                case 2:
                    row = 1;   
                    col = 1;
                    break;          
                case 3:
                    row = 1;   
                    col = 3;
                    break;       
                case 4: row = 1;   
                    col = 5;
                    break;
                case 5:
                    row = 2;
                    col = 0;
                    break;
                case 6:
                    row = 2;
                    col = 2;
                    break;
                case 7:
                    row = 2;
                    col = 4;
                    break;
                case 8:
                    row = 2;
                    col = 6;
                    break;
                case 9:
                    row = 3;
                    col = 1;
                    break;
                case 10:
                    row = 3;
                    col = 3;
                    break;
                case 11:
                    row = 3;
                    col = 5;
                    break;
            }

            
            

        }

    }
}
