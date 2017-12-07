using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DifferentLayoutsWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Label gruss = new Label();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mitte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void anfang_Click(object sender, RoutedEventArgs e)
        {
            dockpanel.LastChildFill = true;

            gruss.Content = "Hallo";
            gruss.FontSize = 56;
            gruss.Name = "gruss";
            gruss.VerticalContentAlignment = VerticalAlignment.Center;
            gruss.HorizontalContentAlignment = HorizontalAlignment.Center;
            
            dockpanel.Children.Add(gruss);
            // MessageBox.Show(" ");
        }

        private void ende_Click(object sender, RoutedEventArgs e)
        {
           //   dockpanel.LastChildFill = false;

           //   dockpanel.Children.Clear();
            dockpanel.Children.Remove(gruss);
            UniformGrid raster = new UniformGrid();
            raster.Background = Brushes.Goldenrod;
            for(int i = 0; i < 16; i++)
            {
                Label l = new Label
                {
                    Content = i
                };
                raster.Children.Add(l);
            }
            dockpanel.Children.Add(raster);
        }
    }
}
