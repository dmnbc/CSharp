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

namespace RaumberechnungWpfApplication
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

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slider != null && slider1 != null && button != null)
            {
                button.Content = "Raumgröße in qm :\n" + (slider.Value / 100) * (slider1.Value / 100)
              + "\n aus " + (slider.Value / 100) + "\n mal " + (slider1.Value / 100);
                if (button.Height > 300)
                {
                    fenster.Height += button.Height - 300;
                }
            }
        }
    }
}
