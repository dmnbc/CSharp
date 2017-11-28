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
using System.Windows.Media.Animation; // nötig
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CanvasWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AnimationClock _clock = null;
        private AnimationClock _clock2 = null;
        public static bool noch_nicht_gemeldet = true;
        public MainWindow()
        {

            InitializeComponent();
          
        }

       

        private void start_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation moveCar = new DoubleAnimation();
            moveCar.From = 10;
            moveCar.To = 500;
            moveCar.Duration = new Duration(TimeSpan.Parse("0:0:10"));
            _clock = moveCar.CreateClock();
            kunde.ApplyAnimationClock(Canvas.TopProperty, _clock);
            _clock.CurrentTimeInvalidated += _clock_CurrentTimeInvalidated;
            
          

            DoubleAnimation enlargeButton = new DoubleAnimation
            {
                From = 100,
                To = 500,
                Duration = new Duration(TimeSpan.Parse("0:0:10"))
            };

            _clock2 = enlargeButton.CreateClock();
            progress.ApplyAnimationClock(Canvas.WidthProperty, _clock2);

        }

        private void _clock_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            progress.Content = kunde.GetValue(Canvas.TopProperty);
            double top;
           // bool noch_nicht_gemeldet = false;
            Double.TryParse((kunde.GetValue(Canvas.TopProperty)).ToString(),out top);
           // kunde.InvalidateProperty(Canvas.TopProperty);
            if((top > 200.0) & noch_nicht_gemeldet)
            {
              //  _clock.Controller.Pause();
                MessageBox.Show("Stop auf halber Strecke");
                noch_nicht_gemeldet = !noch_nicht_gemeldet;
              //  _clock.Controller.Resume();
            }
           
        }
    }  
    
}
