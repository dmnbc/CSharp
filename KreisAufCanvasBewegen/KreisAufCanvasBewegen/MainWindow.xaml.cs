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

namespace KreisAufCanvasBewegen
{
    
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static double strecke;
        public static int durchlauf;
        public MainWindow()
        {
            InitializeComponent();
            strecke = 475;
            durchlauf = 1;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation runterRollen = new DoubleAnimation
            {
                // From = -25,
                To = 475,
               // AutoReverse = true,
              //  RepeatBehavior = RepeatBehavior.Forever,
                Duration = TimeSpan.Parse("0:0:3")
                
                
            };
            DoubleAnimation querRollen = new DoubleAnimation
            {
                // From = -25,
                To = 775,
                // AutoReverse = true,
                //  RepeatBehavior = RepeatBehavior.Forever,
                Duration = TimeSpan.Parse("0:0:30")


            };

            runterRollen.Completed += RunterRollen_Completed;
            kugel.BeginAnimation(Canvas.TopProperty, runterRollen);
            kugel.BeginAnimation(Canvas.LeftProperty, querRollen);

        }

        private void RunterRollen_Completed(object sender, EventArgs e)
        {
            durchlauf++;
            strecke = strecke * .5;
            DoubleAnimation bewegen = new DoubleAnimation
            {
                
                To = 475 - strecke,
                Duration = TimeSpan.Parse("0:0:2"),
                AutoReverse = true
            };
            if (durchlauf < 10)
            { bewegen.Completed += RunterRollen_Completed; }
            else
            { bewegen.Completed -= RunterRollen_Completed;
              bewegen.Completed += ende; }
            kugel.BeginAnimation(Canvas.TopProperty, bewegen);
        }
        private void ende(object sender, EventArgs e)
        {
            MessageBox.Show("das wars");
        }
    }
    
}
