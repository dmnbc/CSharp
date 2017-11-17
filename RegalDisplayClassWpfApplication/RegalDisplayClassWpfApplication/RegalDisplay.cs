using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegalDisplayClassWpfApplication
{
    class Regal
    {
        /* attribute */ 

        public class Display
        {
            public static int margin_from_top; 
            public Label num = new Label();
            public Label inhalt = new Label();
            public Display()
            {
                num.Content = 1;               
                inhalt.Content = 42;
              
            }

            

        }

        public Display d;

         public Regal()
        {
            d = new Display();
        }
        public Label regaldisplay (Regal r)
        {

            Label l = new Label();
            l.Content = r.d.inhalt;
           
            return l;//
        }
    }
}
