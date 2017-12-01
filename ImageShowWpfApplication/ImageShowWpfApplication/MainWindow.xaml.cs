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

namespace ImageShowWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String[] IMAGES = { "1.png", "2.png", "3.png", "4.png", };
        private String pfad = "D:\\D\\_freiberuflich\\github\\csharp\\beispieldateien\\ImageShowWpfApplication\\ImageShowWpfApplication\\";
        private double nr = 0;
        private double z = 1;
        public MainWindow()
        {   

            InitializeComponent();
            foreach(var name in IMAGES)
            { 
                Image i = new Image();
                i.Source = new BitmapImage(new Uri(pfad+name));
                i.Width = 80;
                i.Margin = new Thickness((nr+z++ % 2) * schirm.Width/4, (nr % 2) * schirm.Height / 4 , 0, 0);
                nr++;
                schirm.Children.Add(i);
            }
        }

        private void  button_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation rotate = new ThicknessAnimation();
            Thickness drehung = new Thickness();
            drehung.Top = +160;
            rotate.By = drehung;
            rotate.Duration = TimeSpan.Parse("0:0:4");
            schirm.Children[1].BeginAnimation(Image.MarginProperty, rotate);
            drehung.Top = 0;
            drehung.Left = +320;
            rotate.By = drehung;
            schirm.Children[2].BeginAnimation(Image.MarginProperty, rotate);
            drehung.Top = -160;
            drehung.Left = 0;
            rotate.By = drehung;
            schirm.Children[4].BeginAnimation(Image.MarginProperty, rotate);
            drehung.Top = 0;
            drehung.Left = -320;
            rotate.By = drehung;
            schirm.Children[3].BeginAnimation(Image.MarginProperty, rotate);

        }
    }
}
