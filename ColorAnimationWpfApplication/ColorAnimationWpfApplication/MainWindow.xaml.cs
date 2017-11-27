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

namespace ColorAnimationWpfApplication
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {   // vermeide eine versiegelte Eigenschaft
            window.Background = new SolidColorBrush(Colors.Orange);
            ColorAnimation farbwechsel = new ColorAnimation();
            farbwechsel.From = Colors.Red;
            farbwechsel.To = Colors.Green;
            farbwechsel.Duration = new Duration(TimeSpan.Parse("0:0:16"));
            window.Background.BeginAnimation(SolidColorBrush.ColorProperty, farbwechsel);
            

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.Background = new SolidColorBrush(Colors.Orange);
            ColorAnimation farbwechsel = new ColorAnimation();
            farbwechsel.From = Colors.White;
            farbwechsel.To = Colors.Red;
            farbwechsel.Duration = new Duration(TimeSpan.Parse("0:0:16"));
            btn1.Background.BeginAnimation(SolidColorBrush.ColorProperty, farbwechsel);
        }
    }
}
