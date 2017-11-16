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

namespace PureCSharpWpfApplication
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Raum verkauf = new Raum();
            for (int i = 0; i < 80; i++)
            {
                Label regal = new Label();
                regal.Margin = new Thickness(5, 15, 5, 5);
                regal.Width = 75;
                regal.Height = 40;
                regal.FontSize = 28;
                regal.Content = verkauf.regale[i];
                grid.Children.Add(regal);
            }
        }
    }
}
