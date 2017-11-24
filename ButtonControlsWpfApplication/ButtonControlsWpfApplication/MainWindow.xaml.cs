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
        public static string Bildpfad;
        public MainWindow()
        {
            Bildpfad = "D:\\D\\_freiberuflich\\github\\csharp\\beispieldateien\\ButtonControlsWpfApplication\\ButtonControlsWpfApplication\\bin\\Debug\\";
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
            Image content = new Image();
            content.Source = new BitmapImage(new Uri(Bildpfad+"check.png"));
            toggle_img.Content = content;

          //   toggle_img.Background = Properties.Resources.

        }
        private void toggle_unchecked(object sender, RoutedEventArgs e)
        {
            inaktiv_toggle.Content = "nicht aktiv";
            aktiv_toggle.Content = "";
            Image content = new Image();
            content.Source = new BitmapImage(new Uri("uncheck.png"));
            toggle_img.Content = content;
        }

        private void repeat_clicked(object sender, RoutedEventArgs e)
        {
            repeat_count.Content = Convert.ToInt32(repeat_count.Content.ToString())+1;
          
        }
        private void repeat_clickedDown(object sender, RoutedEventArgs e)
        {
            repeat_count.Content = Convert.ToInt32(repeat_count.Content.ToString()) - 1;

        }
    }
}
