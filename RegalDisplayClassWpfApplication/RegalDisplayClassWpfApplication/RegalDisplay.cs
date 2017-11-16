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
    class RegalDisplay
    {
        public class Display
        {
            public static int margin_from_top; 
            public Label num = new Label();
            public Label inhalt = new Label();
            public Display()
            {
                num.Content = 1;
                num.Margin = new Thickness(5, margin_from_top, 5, 5);
                inhalt.Content = 42;
                inhalt.Margin = new Thickness(5, margin_from_top+=20, 5, 5);
            }

            

        }

        public Display d;

         public RegalDisplay()
        {
            d = new Display();
        }
        public void regaldisplay(Grid wo, RegalDisplay r)
        {
            wo.Children.Add(r.d.num);
            wo.Children.Add(r.d.inhalt);
        }
    }
}
