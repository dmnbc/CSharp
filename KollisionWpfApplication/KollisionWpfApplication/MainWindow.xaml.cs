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

namespace KollisionWpfApplication
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

        private void abfeuern_Click(object sender, RoutedEventArgs e)
        {
            ThicknessAnimation schuss = new ThicknessAnimation();
            schuss.To = Ziel.Margin;
            schuss.Duration = TimeSpan.Parse("0:0:5");
            Schuss.BeginAnimation(MarginProperty, schuss);
          
        }

        private void abgefragt(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("jetzt mal vergleichen");
        }
    }
}
