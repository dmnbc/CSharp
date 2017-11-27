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

namespace OpacityAnimationWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void verblassen_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation fade = new ThicknessAnimation();
            fade.From = new Thickness(1,1,0,0);
            fade.To = new Thickness(200, 200, 0, 0);
            fade.Duration = TimeSpan.Parse("0:0:5");
            text.BeginAnimation(TextBox.MarginProperty, fade);
        }
    }
}
