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

namespace SyntaxWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn_1.Content = "k1";         
            btn_2.Content = "k2";
            btn_3.Content = "k3";
            btn_4.Content = "k4";
            /*
                         for(int i = 0; i < 50; i++)
                      {    
                           Button btn = new Button(); 
                           btn.Name = "btn_" + i.ToString();
                            btn.Content = "k" + i.ToString();
                            btn.BorderThickness = new Thickness(4, 4, 4, 4);
                            btn.BorderBrush = new SolidColorBrush(Color.FromRgb(0, 255, 0));
                            anzeigeFeld.Children.Add(btn);


                          } 
            */
            int z;
            z = anzeigeFeld.Children.Count;
            anzahlAnzeige.Content = "Es sind "+z+" Felder im Grid";
        }
    }
}
