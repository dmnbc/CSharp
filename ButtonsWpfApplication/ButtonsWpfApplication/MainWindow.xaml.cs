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

namespace ButtonsWpfApplication
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

        public void up(object sender, RoutedEventArgs e)
        {
            l.Content = Convert.ToInt32(l.Content.ToString()) + 1;
        }
        public void down(object sender, RoutedEventArgs e)
        {
            l.Content = Convert.ToInt32(l.Content.ToString()) - 1;
        }
    }
}
