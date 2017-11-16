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

namespace SliderWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bewegt(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Anzeige.Text = volumen.Value.ToString();
            Fenster.Height = 350 - volumen.Value;
            Color myrgb = new Color();
            myrgb = Color.FromRgb(255, 225, (byte)volumen.Value);
            Fenster.Background = new SolidColorBrush(myrgb);
        }
    }
}
