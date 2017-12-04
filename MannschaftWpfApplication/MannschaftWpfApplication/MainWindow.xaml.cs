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

namespace MannschaftWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bilder sammlung = new Bilder();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Image bild = new Image();
            Spieler.lfd_nr = 1;
                for (int i = 0;i < 11;i++)
            {
                Spieler s = new Spieler();
               // bild = new Image();
               // bild.Source = new BitmapImage(new Uri("D:\\D\\_freiberuflich\\github\\csharp\\beispieldateien\\MannschaftWpfApplication\\MannschaftWpfApplication\\image.jpg"));

                //   spieleranlegen.Content = s.rueckennummer;
                StackPanel p = new StackPanel();
                p.Background = Brushes.Transparent;
                p.Children.Add(s.bild);
                Label l = new Label();
                l.Content = s.rueckennummer;
                p.Children.Add(l);
                Aufstellung.Children.Add(p);
                Grid.SetRow(p, s.row);
                Grid.SetColumn(p, s.col);

            }
        }
    }
}
