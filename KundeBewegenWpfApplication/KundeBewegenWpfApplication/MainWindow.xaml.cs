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

namespace KundeBewegenWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AnimationClock _taktgeberRunter = null;
        private AnimationClock _taktgeberQuer = null;
        public static double raumlaenge = 400;
        public static double raumbreite = 600;
        public static bool nochNichtBesucht = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bewegung_Click(object sender, RoutedEventArgs e)
        {  // der Start der Bewegung soll auf Click erfolgen

            // Bewegungsparameter festlegen
            DoubleAnimation kundeBewegung = new DoubleAnimation
            {
                  From = 0,
                  To = raumlaenge,
               // By = 100,
                Duration = TimeSpan.Parse("0:0:59")
            };
            DoubleAnimation kundeBewegungQuer = new DoubleAnimation
            {
                From = 0,
                To = raumbreite,
                AutoReverse = true,
                Duration = TimeSpan.Parse("0:0:10")
            };
            _taktgeberRunter = kundeBewegung.CreateClock();
            _taktgeberQuer = kundeBewegungQuer.CreateClock();
            kunde.ApplyAnimationClock(Canvas.TopProperty, _taktgeberRunter);
            kunde.ApplyAnimationClock(Canvas.LeftProperty, _taktgeberQuer);
            _taktgeberQuer.Controller.Pause();

            _taktgeberRunter.Completed += taktgeberRunterCompleted;    // event, der am Ende einmal ....
            _taktgeberRunter.CurrentTimeInvalidated += taktgeberRunterTickt;

            EventHandler weiterRunter = (s, x) => _taktgeberRunter.Controller.Resume();
            _taktgeberQuer.Completed += weiterRunter; 

        }

        private void taktgeberRunterCompleted(object sender, EventArgs e)
        {
            bewegung.Content = "angekommen";
        }

        private void taktgeberRunterTickt(object sender, EventArgs e)
        {
            
            bewegung.Content = kunde.GetValue(Canvas.TopProperty); //_taktgeberRunter.CurrentTime.ToString();
            double aktuellePosition;
            Double.TryParse((kunde.GetValue(Canvas.TopProperty).ToString()),out aktuellePosition);
            double gangAnfang;
            Double.TryParse((gang1.GetValue(Canvas.TopProperty).ToString()), out gangAnfang);

            if ((aktuellePosition % gangAnfang > 77) & nochNichtBesucht )
            {
                bewegung.Content="jetzt abbiegen";
                _taktgeberRunter.Controller.Pause();
                _taktgeberQuer.Controller.Resume();
                nochNichtBesucht = !nochNichtBesucht;
        //        _taktgeberRunter.Controller.Resume(); ist zu früh, dann ist quer noch nicht fertig


            }
            if ((aktuellePosition % gangAnfang )< 5)
                {
                nochNichtBesucht = true;
                _taktgeberQuer.Controller.Begin();
                _taktgeberQuer.Controller.Pause();
            }


        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            _taktgeberRunter.Controller.Begin();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            _taktgeberRunter.Controller.Pause();
        }

        private void weiter_Click(object sender, RoutedEventArgs e)
        {
            _taktgeberRunter.Controller.Resume();
        }

        private void ende_Click(object sender, RoutedEventArgs e)
        {
            _taktgeberRunter.Controller.SkipToFill();
        }

        private void liste_Click(object sender, RoutedEventArgs e)
        {
            _taktgeberRunter.Controller.Pause();
            MessageBox.Show("Anzeige der Einkaufsliste");
            _taktgeberRunter.Controller.Resume();
        }

        private void kunde_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _taktgeberRunter.Controller.Pause();
            MessageBox.Show("Anzeige der Einkaufsliste");
            _taktgeberRunter.Controller.Resume();

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speedration.Content = e.NewValue;
            if (_taktgeberRunter != null)
            {
                var bindung = new Binding();
                bindung.Source = _taktgeberRunter.Controller;
                bindung.Path = new PropertyPath("SpeedRatio");
                slider.SetBinding(Slider.ValueProperty, bindung);
            }
        }
    }
}
