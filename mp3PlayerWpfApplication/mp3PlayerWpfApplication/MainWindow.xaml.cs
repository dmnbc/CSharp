using Microsoft.Win32;
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

namespace mp3PlayerWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // private MediaElement mediaPlayer = new MediaElement();
        public MainWindow()
        {
            InitializeComponent();
         //   mediaPlayer.Height = 300;
         //   mediaPlayer.Width = 500;
        }

        private void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\D\\_privat\\musik\\MP3Files";
            openFileDialog.Filter = "MP files (*.mp*)|*.mp*|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            { 
                mediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
                mediaPlayer.Source =new Uri ((openFileDialog.FileName));
                mediaPlayer.LoadedBehavior = MediaState.Manual;
               
            }
        }

        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            MessageBox.Show("Lied zu Ende ");
        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
        private void stopBtn_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
        private void weiterBtn_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }
    }
}
