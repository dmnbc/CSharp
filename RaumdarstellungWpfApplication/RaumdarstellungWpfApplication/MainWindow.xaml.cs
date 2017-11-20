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

namespace RaumdarstellungWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Label headline = new Label
            {
                Content = "VERKAUFSRAUM",
                HorizontalAlignment = HorizontalAlignment.Center,
                Background = Brushes.BurlyWood
            };
            Verkauf.Children.Add(headline);
            for(int i = 0; i < 10; i++)
            {
                StackPanel gang = new StackPanel();
                gang.Name = "Gang" + i;
                gang.Orientation=System.Windows.Controls.Orientation.Horizontal;
                for (int j = 0; j < 40; j++)
                {
                    StackPanel rgr = new StackPanel();
                    rgr.Orientation = System.Windows.Controls.Orientation.Vertical;
                    Label regal_l = new Label { Content = "R"+ ((i*40+j)*2).ToString("D3") };
                    Label leer    = new Label { Content = " " }; leer.Background = Brushes.AntiqueWhite;
                    Label regal_r = new Label { Content = "R"+(((i * 40 + j) * 2)+1).ToString("D3") };
                    rgr.Children.Add(regal_l);
                    rgr.Children.Add(leer);
                    rgr.Children.Add(regal_r);

                    gang.Children.Add(rgr);
                }
                
                Verkauf.Children.Add(gang);
            }
            
        }
    }
}
