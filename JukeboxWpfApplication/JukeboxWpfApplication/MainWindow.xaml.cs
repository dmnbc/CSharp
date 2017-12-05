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

namespace JukeboxWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaTimeline _timeLine;
        private MediaClock _clock;
        public static string pfad = "D:\\D\\_privat\\musik\\MP3Files\\";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var gewaehlt = sender as RadioButton;
            MessageBox.Show(pfad+gewaehlt.Tag.ToString());
            _timeLine = new MediaTimeline();
            _timeLine.Source = new Uri(pfad + gewaehlt.Tag.ToString());
     //       _timeLine.Source = new Uri(gewaehlt.Tag.ToString());
            _clock = _timeLine.CreateClock();
            _clock.CurrentTimeInvalidated += _clock_CurrentTimeInvalidated;
            _clock.Controller.Stop();
            MediaPlayer player = new MediaPlayer();
            player.MediaOpened += Player_MediaOpened;
            player.Clock = _clock;
        }

        private void Player_MediaOpened(object sender, EventArgs e)
        {
            MediaPlayer temp = sender as MediaPlayer;
            progressbar.Maximum = temp.NaturalDuration.TimeSpan.Ticks;
        }

        private void _clock_CurrentTimeInvalidated(object sender, EventArgs e)
        {
            laufzeit.Text = _clock.CurrentTime.ToString();
            progressbar.Value = _clock.CurrentTime.Value.Ticks;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _clock.Controller.Begin();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
