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

namespace EigenKlasseInWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Kunde.kundenummer = 1;
            // hier geht es schon, aber dann
            // ist noch keine fertiges Fenster gezeichnet 
            // Kunde meier = new Kunde();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Kunde meier = new Kunde();

            raumdarstellung.Children.Add(new Image() { Source = meier.wagen.Source });
            Canvas.SetLeft(raumdarstellung.Children[raumdarstellung.Children.Count - 1], 30);
            Kunde schulz = new Kunde();
            raumdarstellung.Children.Add(new Image() { Source = schulz.wagen.Source });
            Canvas.SetLeft(raumdarstellung.Children[raumdarstellung.Children.Count - 1], 60);
            Kunde schmidt = new Kunde();
            raumdarstellung.Children.Add(new Image() { Source = schmidt.wagen.Source });
            Canvas.SetLeft(raumdarstellung.Children[raumdarstellung.Children.Count - 1], 90);

        }
    }
}
