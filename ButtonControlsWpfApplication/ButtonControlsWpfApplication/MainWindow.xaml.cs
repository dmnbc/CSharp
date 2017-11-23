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

namespace ButtonControlsWpfApplication
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

       private void simple_geklickt(object sender, RoutedEventArgs e)
        {
            
            label_simple.Content = "Simple wurde geklickt";
        }
        private void toggle_geklickt(object sender, RoutedEventArgs e)
        {

            label_toggle.Content = "Toggle wurde geklickt";
        }

        private void toggle_checked(object sender, RoutedEventArgs e)
        {
            aktiv_toggle.Content = "aktiv";
            inaktiv_toggle.Content = "";
        }
        private void toggle_unchecked(object sender, RoutedEventArgs e)
        {
            inaktiv_toggle.Content = "nicht aktiv";
            aktiv_toggle.Content = "";
        }
    }
}
