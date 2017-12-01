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
using System.Windows.Media.Animation;
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
        public static int anzKunden = 0;
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
      

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            anzKunden = Int32.Parse(slider.Value.ToString());
            bool autoreverse = true;
            ThicknessAnimation x = new ThicknessAnimation();
            Thickness bla = new Thickness();
            bla.Left = 400;
            
           
            x.Duration = TimeSpan.Parse("0:0:10");
            x.BeginTime = TimeSpan.Parse("0:0:" + Kunde.kundenummer);
            for (int i = 0; i < anzKunden; i++)
            {

                Kunde n = new Kunde();
                n.wagen.MouseDown += Wagen_MouseDown;
                n.wagen.Margin =  new Thickness(20 * Kunde.kundenummer, 30 * Kunde.kundenummer, 0, 0);
                raumdarstellung.Children.Add(n.wagen);

                bla.Top = n.wagen.Margin.Top;
                x.To = bla;
                x.AutoReverse = autoreverse;
                n.wagen.BeginAnimation(Image.MarginProperty, x);
                autoreverse = !autoreverse;
                    
            }
        }



        private void Wagen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }
    }
}
